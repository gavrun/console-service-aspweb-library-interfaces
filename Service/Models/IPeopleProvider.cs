using Common;
//connected
using System.Collections.Generic;

namespace Service.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
