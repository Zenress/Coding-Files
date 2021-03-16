using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavn.WpfItemsControls.Exercise1.Model
{
    public class Person
    {
        public string FullName { get{ return $"{FirstName} {LastName}"; } }
        public string FirstName;
        public string LastName;
        public string Email;
        public string TlfNr;
        public Person(string firstName, string lastName, string eMail, string tlfNr)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = eMail;
            TlfNr = tlfNr;
        }
        public override string ToString()
        {
            // choose any format that suits you and display what you like
            return String.Format("Name: {0}", this.FullName);
        }
    }
}
