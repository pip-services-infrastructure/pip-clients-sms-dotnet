using System.Threading.Tasks;
using PipServices3.Commons.Config;

namespace PipServices.Sms.Client.Version1
{
    public class SmsNullClientV1 : ISmsClientV1
    {
        public Task SendMessageAsync(string correlationId, SmsMessageV1 message, ConfigParams parameters)
        {
            return DoNothingAsync();
        }

        public Task SendMessageToRecipientAsync(string correlationId, SmsRecipientV1 recipient, SmsMessageV1 message, ConfigParams parameters)
        {
            return DoNothingAsync();
        }

        public Task SendMessageToRecipientsAsync(string correlationId, SmsRecipientV1[] recipients, SmsMessageV1 message, ConfigParams parameters)
        {
            return DoNothingAsync();
        }

        private Task DoNothingAsync()
        {
            return Task.Delay(0);
        }
    }
}
