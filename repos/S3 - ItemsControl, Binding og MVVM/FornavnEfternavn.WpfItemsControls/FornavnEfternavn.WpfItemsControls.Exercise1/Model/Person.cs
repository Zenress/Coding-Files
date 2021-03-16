using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornavnEfternavn.WpfItemsControls.Exercise1.Model
{
    public class Person
    {
        public string FullName;
        public Person(string firstName, string lastName, string eMail, string tlfNr)
        {
            FullName = firstName + " " + lastName;
        }
    }
}
