using System;

namespace Common
{
    //common class for person object
    public class Person
    {
        public int Id { get; set; }
        public string? GivenName { get; set; }
        public string? FamilyName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }
        public string? FormatString { get; set; }

        //overriding ToString ? why?
        public override string ToString() //misplaced return
        {
            if (string.IsNullOrEmpty(FormatString))
            {
                FormatString = "{0} {1}";
            }
            return string.Format(FormatString, GivenName, FamilyName);
        }
    }
}
