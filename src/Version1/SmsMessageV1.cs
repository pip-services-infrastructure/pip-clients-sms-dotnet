using System.Runtime.Serialization;

namespace PipServices.Sms.Client.Version1
{
    [DataContract]
    public class SmsMessageV1
    {
        [DataMember(Name = "from")]
        public string From { get; set; }

        [DataMember(Name = "to")]
        public string To { get; set; }

        [DataMember(Name = "text")]
        public object Text { get; set; }
    }
}
