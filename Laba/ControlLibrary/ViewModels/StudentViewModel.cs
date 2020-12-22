using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Library.ViewModels
{
    [JsonObject(MemberSerialization.Fields)]
    //[DataContract]
    public class StudentViewModel
    {
        [JsonProperty()]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [JsonProperty("Encoding.UTF8")]
        [DisplayName("ФИО")]
        public string FIO { get; set; }
        [DataMember]
        [JsonProperty()]
        [DisplayName("Дата поступдения")]
        public DateTime DatePostuplen { get; set; }
        [DataMember]
        public Dictionary<string, string> Napravlenies { get; set; }
    }
}
