using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaizen.CaseStudy.JsonParse.Models;
using Newtonsoft.Json;

namespace Kaizen.CaseStudy.JsonParse.Helpers
{
    public class JsonReaderHelper
    {
        public static List<OcrDataModel> ReadJson(string path)
        {
            if (!System.IO.File.Exists(path))
                throw new Exception("File does not exists");

            using (TextReader reader = new StreamReader(System.IO.File.Open(path, FileMode.Open)))
            {
                try
                {
                    var jsonString = reader.ReadToEnd();
                    var data = JsonConvert.DeserializeObject<List<OcrDataModel>>(jsonString);
                    return data;
                }
                catch (Exception)
                {
                    throw new Exception("File couldn't open and read");
                }
            }
        }
    }
}
