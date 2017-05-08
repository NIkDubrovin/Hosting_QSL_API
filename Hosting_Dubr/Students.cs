using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using Newtonsoft.Json;  // Подключаем Newtonsoft.Json

namespace Hosting_Dubr
{
    public class Student
    {
        #region Пременные класса + их парсинг из Json в удобную коллекцию элемнетов, для того чтобы их воспринимал класс

        [JsonProperty("id")]
        public int Id { set; get; }

        [JsonProperty("first_name")]
        public string FirstName { set; get; }

        [JsonProperty("last_name")]
        public string LastName { set; get; }

        [JsonProperty("sex")]
        public int Sex { set; get; }

        [JsonProperty("age")]
        public int Age  { set; get; }

        [JsonProperty("description")]
        public string Description { set; get; }

        #endregion
    }
}
