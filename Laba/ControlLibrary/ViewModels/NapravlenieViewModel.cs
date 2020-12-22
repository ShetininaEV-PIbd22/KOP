using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Library.ViewModels
{
    [JsonObject(MemberSerialization.Fields)]
    [DataContract]
    public class NapravlenieViewModel
    {
        [JsonProperty()]
        [DataMember]
        public int? Id { get; set; }
        [JsonProperty("Encoding.UTF8")]
        [DataMember]
        [DisplayName("Название направления!")]
        public string Name { get; set; }
        //[DataMember]
        private Dictionary<int, (string, DateTime)> Students { get; set; }
    }
}
