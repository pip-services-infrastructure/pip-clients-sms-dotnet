﻿using PipServices.Sms.Client.Version1;
using PipServices3.Commons.Config;
using System;

namespace run
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var correlationId = "123";
                var config = ConfigParams.FromTuples(
                    "connection.type", "http",
                    "connection.host", "localhost",
                    "connection.port", 8080
                );
                var client = new SmsHttpClientV1();
                var parameters = ConfigParams.FromTuples(
                    "subject", "Test Sms To Address",
                    "text", "This is just a test"
                );
                client.Configure(config);
                client.OpenAsync(correlationId);
                client.SendMessageAsync(correlationId, new SmsMessageV1()
                    {
                        To = "+15203452335",
                        Text = "{{text}}"
                    }, 
                    parameters);
                Console.WriteLine("Message send");

                Console.WriteLine("Press ENTER to exit...");
                Console.ReadLine();

                client.CloseAsync(string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
