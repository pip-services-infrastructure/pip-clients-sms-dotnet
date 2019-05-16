using PipServices.Sms.Client.Version1;
using PipServices3.Commons.Refer;
using PipServices3.Components.Build;

namespace PipServices.Sms.Client.Build
{
    public class SmsClientFactory : Factory
    {
        public static Descriptor Descriptor = new Descriptor("pip-services-sms", "factoty", "*", "*", "1.0");
        public static Descriptor NullClientV1Descriptor = new Descriptor("pip-services-sms", "client", "null", "*", "1.0");
        public static Descriptor HttpClientV1Descriptor = new Descriptor("pip-services-sms", "client", "http", "*", "1.0");

        public SmsClientFactory()
        {
            RegisterAsType(NullClientV1Descriptor, typeof(SmsNullClientV1));
            RegisterAsType(HttpClientV1Descriptor, typeof(SmsHttpClientV1));
        }
    }
}
