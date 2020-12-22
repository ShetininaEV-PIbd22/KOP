using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Library.BindingModels
{
    public class NapravlenieBindingModel
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Dictionary<int, (string, DateTime)> Students { get; set; }
    }
}
