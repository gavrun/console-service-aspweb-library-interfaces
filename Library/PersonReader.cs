using System;
using System.Collections.Generic;

namespace Library
{
    public class PersonReader
    {
        //service initializer ? how does it work?

        #region Service initializers
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874";
        JsonSerializerOptions options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        #endregion

        public List<Person> GetPeople();


        public Person GetPerson();




    }
}
