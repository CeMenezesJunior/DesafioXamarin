using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioXamarin.Deserialize
{
    public class Record
    {
        public string id { get; set; }
        public Fields fields { get; set; }
        public DateTime createdTime { get; set; }
    }
}
