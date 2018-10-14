using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGroups
{
    class Person
    {
        public string name;
        public string surname;
        public string email;      

        public Person(string name = null, string surname = null, /*int age = 0,*/ string email = null)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;            
        }


    }
}
