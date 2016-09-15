using System.Runtime.Serialization;

namespace Library.DataContract
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public long BookId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string Publisher { get; set; }
        [DataMember]
        public string Subject { get; set; }
    }
}
