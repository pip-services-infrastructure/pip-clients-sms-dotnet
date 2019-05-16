using PipServices3.Commons.Data;
using System.Runtime.Serialization;

namespace PipServices.Sms.Client.Version1
{
    [DataContract]
    public class SmsRecipientV1 : IStringIdentifiable
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }
    }
}
