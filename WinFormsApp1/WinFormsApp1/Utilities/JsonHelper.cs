using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsApp1.Utilities
{
    public static class JsonHelper
    {
        public static void SaveToFile<T>(string path, T data, bool indented = true)
        {
            var formatting = indented ? Formatting.Indented : Formatting.None;
            string json = JsonConvert.SerializeObject(data, formatting);
            File.WriteAllText(path, json);
        }

        public static T? LoadFromFile<T>(string path)
        {
            if (!File.Exists(path)) return default;
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T? Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string Serialize<T>(T obj, bool indented = true)
        {
            var formatting = indented ? Formatting.Indented : Formatting.None;
            return JsonConvert.SerializeObject(obj, formatting);
        }
    }
}
