//using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace ControlLibrary
{
    public partial class ComponentStore : Component
    {
        string name;
        
        public ComponentStore()
        {
            InitializeComponent();
        }

        public ComponentStore(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public List<object> GetData()
        {
            List<object> result;
            string path = name + ".json";
            string text = "";
            using (StreamReader sr = new StreamReader(path))
            {
                text = sr.ReadToEnd();
                Console.WriteLine(text);
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(text);
                Console.WriteLine(result.ToString());
            }
            return result;
        }

        public void SaveData<T>(string path, List<T> list) where T : class, new()
        {
            Type type = typeof(T);
            //DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            name = path + type.Name;
            using (FileStream fs = new FileStream(string.Format("{0}.json", name), FileMode.Create))//FileMode.OpenOrCreate))
            {
                var option = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                var opt = new JsonWriterOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    Indented = true,
                };
                Utf8JsonWriter utf = new Utf8JsonWriter(fs, opt);
                JsonSerializer.Serialize<List<T>>(utf, list, option);
                //jsonFormatter.WriteObject(fs,list);
            }
        }
    }
}
