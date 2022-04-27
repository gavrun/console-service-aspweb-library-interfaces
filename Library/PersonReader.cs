using Common;
// connected
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Library
{
    public class PersonReader
    {
        //service initializer ? how does it work?

        #region Service initializers
        WebClient client = new WebClient();
        string baseUri = "http://localhost:5000"; //changed ports
        JsonSerializerOptions options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        #endregion

        //public Person[] GetPeople()
        //{
        //    string address = $"{baseUri}/people";
        //    string reply = client.DownloadString(address);
        //    var result = JsonSerializer.Deserialize<List<Person>>(reply, options);
        //    if (result is null)
        //    {
        //        result = new List<Person>();
        //    }
        //    return result.ToArray();
        //}

        //
        public List<Person> GetPeople()
        {
            string address = $"{baseUri}/people";

            string reply = client.DownloadString(address); //autocorrected string to var then to string?

            var result = JsonSerializer.Deserialize<List<Person>>(reply, options);

            if (result is null)
            {
                result = new List<Person>();
            }
            return result;
        }

        //
        public Person GetPerson(int id)
        {
            var address = $"{baseUri}/people/{id}";

            string reply = client.DownloadString(address);

            var result = JsonSerializer.Deserialize<Person>(reply, options);

            if (result is null)
            {
                result = new Person();
            }
            return result;

        }
    }
}
