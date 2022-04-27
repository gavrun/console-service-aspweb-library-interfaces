//connect to ?
using Common;

using System.Collections.Generic;

namespace Service.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
