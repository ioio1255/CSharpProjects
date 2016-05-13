using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonConvertTool
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonOutput="{\"id\":\"108013515952807\",\"posts\":{\"data\":[{\"id\":\"108013515952807_470186843068804\",\"created_time\":\"2013-05-14T20:43:28+0000\"},{\"message\":\"TEKST\",\"id\":\"108013515952807_470178529736302\",\"created_time\":\"2013-05-14T20:22:07+0000\"}";
            var myelement= JsonConvert.DeserializeXmlNode(jsonOutput, "myelement");
            
        }
    }
}
