using System.Threading.Tasks;
using PipServices3.Commons.Config;
using PipServices3.Rpc.Clients;

namespace PipServices.Sms.Client.Version1
{
    public class SmsHttpClientV1 : CommandableHttpClient, ISmsClientV1
    {
        public SmsHttpClientV1() : base("v1/sms")
        { }

        public SmsHttpClientV1(object config) : base("v1/sms")
        {
            if (config != null)
                this.Configure(ConfigParams.FromValue(config));
        }

        public Task SendMessageAsync(string correlationId, SmsMessageV1 message, ConfigParams parameters)
        {
            using (var timing = Instrument(correlationId))
            {
                return CallCommandAsync<Task>(
                    "send_message",
                    correlationId,
                    new
                    {
                        message = message,
                        parameters = parameters
                    }
                    );
            }
        }

        public Task SendMessageToRecipientAsync(string correlationId, SmsRecipientV1 recipient, SmsMessageV1 message, ConfigParams parameters)
        {
            using (var timing = Instrument(correlationId))
            {
                return CallCommandAsync<Task>(
                    "send_message_to_recipient",
                    correlationId,
                    new
                    {
                        recipient = recipient,
                        message = message,
                        parameters = parameters
                    }
                    );
            }
        }

        public Task SendMessageToRecipientsAsync(string correlationId, SmsRecipientV1[] recipients, SmsMessageV1 message, ConfigParams parameters)
        {
            using (var timing = Instrument(correlationId))
            {
                return CallCommandAsync<Task>(
                    "send_message_to_recipients",
                    correlationId,
                    new
                    {
                        recipients = recipients,
                        message = message,
                        parameters = parameters
                    }
                    );
            }
        }
    }
}
