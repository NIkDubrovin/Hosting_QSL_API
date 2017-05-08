using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;  // Подеключаем Newtonsoft.Json

namespace Hosting_Dubr
{
    class Table
    {
        [JsonProperty("Tables_in_id1494332_dubr")]
        public string NameTable { set; get; }
    }
}
