using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IPersonReader
    {
        //what for?
        IEnumerable<Person> GetPeople();
        
        //get person id
        Person GetPerson(int id);
    }
}
