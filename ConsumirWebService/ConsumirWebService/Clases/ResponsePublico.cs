using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumirWebService.Clases
{
    public class Data
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
    }

    public class ResponsePublico
    {
        public object meta { get; set; }
        public Data data { get; set; }
    }

    
}
