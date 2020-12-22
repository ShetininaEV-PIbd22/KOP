using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Library.BindingModels
{
    public class StudentBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public DateTime DatePostuplen { get; set; }
        [DataMember]
        public Dictionary<string, string> Napravlenies { get; set; }
    }
}
