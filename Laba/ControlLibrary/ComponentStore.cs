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
        public ComponentStore()
        {
            InitializeComponent();
        }

        public ComponentStore(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public List<T> GetData<T>(string path)
        {
            List<T> result;
            if (!Check(typeof(T)))
            {
                throw (new Exception("Класс не настроен для работы."));
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(text);
                Console.WriteLine(result.ToString());
            }
            return result;
        }

        public void SaveData<T>(string path, List<T> list) where T : class, new()
        {
            Type type = typeof(T);
            if (!Check(type))
            {
                throw(new Exception("Класс не настроен для работы."));
            }
            string name = path + type.Name;
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
            }
        }
        private bool Check(Type type)
        {
            var attrib = type.CustomAttributes;//атрибуты класса
            foreach (var atr in attrib)
            {
                Console.WriteLine(atr.ToString());
                if (atr.ToString().Contains("JsonObjectAttribute"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
