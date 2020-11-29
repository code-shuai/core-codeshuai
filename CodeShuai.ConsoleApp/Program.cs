
using Newtonsoft.Json;
using System;
using System.IO;

namespace CodeShuai.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonfile = "caocao.json";
            //JToken
            using (StreamReader file = File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    
                    //var o = (JObject)JToken.ReadFrom(reader);
                    //string a = o["lotname"].ToString();
                    //var b = o["other"];
                    //var c = b["lotaddress"];
                    //var d = o["devices"];
                    //foreach (JObject e in d)
                    //{
                    //    var deviceID = e["deviceID"];
                    //    var name = e["name"];
                    //    var IP = e["IP"];
                    //}
                }
            }






            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
