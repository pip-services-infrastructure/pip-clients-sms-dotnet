using PipServices3.Commons.Config;
using System.Threading.Tasks;

namespace PipServices.Sms.Client.Version1
{
    public interface ISmsClientV1
    {
        Task SendMessageAsync(string correlationId, SmsMessageV1 message, ConfigParams parameters);
        Task SendMessageToRecipientAsync(string correlationId, SmsRecipientV1 recipient, SmsMessageV1 message, ConfigParams parameters);
        Task SendMessageToRecipientsAsync(string correlationId, SmsRecipientV1[] recipients, SmsMessageV1 message, ConfigParams parameters);
    }
}
