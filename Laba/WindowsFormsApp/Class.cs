using ControlLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp
{
    [JsonObject(MemberSerialization.Fields)]
    [DataContract]
    public class Class
    {
        [JsonPropertyName("Id: ")]
        [Column(title: "ID!", width: 40, visible:true)]
        //[DataMember]
        public int id { get; set; }
        //gridViewAutoSize: DataGridViewAutoSizeColumnMode.Fill

        [JsonProperty("Encoding.UTF8")]
        [JsonPropertyName("Text_: ")]
        [Column(title: "Текст", width:100, visible: true)]
        //[DataMember]
        public string Text { get; set; }
        
        [JsonProperty("Encoding.UTF8")]
        [JsonPropertyName("Name_: ")]
        [Column(title: "Имя", width: 100, visible: true)]
        //[DataMember]
        public string Name { get; set; }

        [JsonPropertyName("Phone: ")]
        [Column(title: "Телефон", width: 100, visible: true)]
        //[DataMember]
        public string Phone { get; set; }

        [JsonPropertyName("Age: ")]
        [Column(title: "Возраст", width: 100, visible: true)]
        //[DataMember]
        public int Age { get; set; }

        public List<string> Properties() => new List<string> 
        { 
          "id", 
          "Text",
          "Name",
          "Phone",
          "Age"
        };
    }
}
