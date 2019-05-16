using PipServices.Sms.Client.Version1;
using PipServices3.Commons.Config;
using System;
using System.Threading.Tasks;
using Xunit;

namespace PipServices.Sms.Client.Test.Version1
{
    public class SmsHttpClientV1Test : IDisposable
    {
        private static readonly ConfigParams HttpConfig = ConfigParams.FromTuples(
        "connection.protocol", "http",
        "connection.host", "localhost",
        "connection.port", 8080);

        private readonly SmsHttpClientV1 _client;
        private readonly SmsClientFixtureV1 _fixture;

        public SmsHttpClientV1Test()
        {
            _client = new SmsHttpClientV1();
            _client.Configure(HttpConfig);

            _fixture = new SmsClientFixtureV1(_client);

            _client.OpenAsync(null);
        }

        [Fact]
        public async Task TestSendSmsToAddress()
        {
            await _fixture.TestSendSmsToAddressAsync();
        }

        [Fact]
        public async Task TestSendSmsToRecipients()
        {
            await _fixture.TestSendSmsToRecipientsAsync();
        }

        public void Dispose()
        {
            _client.CloseAsync(null);
        }
    }
}
