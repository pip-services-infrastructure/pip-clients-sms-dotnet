using PipServices.Sms.Client.Version1;
using PipServices3.Commons.Config;
using System.Threading.Tasks;
using Xunit;

namespace PipServices.Sms.Client.Test.Version1
{
    public class SmsClientFixtureV1
    {
        private ISmsClientV1 _client;

        public SmsClientFixtureV1(ISmsClientV1 client)
        {
            _client = client;
        }

        public async Task TestSendSmsToAddressAsync()
        {
            SmsMessageV1 message = new SmsMessageV1 () {
                To = "+15203452335",
                Text = "{{text}}"
            };

            var parameters = ConfigParams.FromTuples(
                "subject", "Test Sms To Address",
                "text", "This is just a test"
            );

            await this._client.SendMessageAsync(null, message, parameters);
            Assert.True(!this._client.SendMessageAsync(null, message, parameters).IsFaulted);
        }

        public async Task TestSendSmsToRecipientsAsync()
        {
            SmsMessageV1 message = new SmsMessageV1()
            {
                Text = "This is just a test"
            };

            SmsRecipientV1 recipient = new SmsRecipientV1()
            {
                Id = "1",
                Phone = "+152023452335",
                Name = "Test Recipient"
            };

            await this._client.SendMessageToRecipientAsync(null, recipient, message, null);
            Assert.True(!this._client.SendMessageToRecipientAsync(null, recipient, message, null).IsFaulted);
        }
    }
}
