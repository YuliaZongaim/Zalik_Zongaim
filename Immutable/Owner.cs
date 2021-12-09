using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Immutable
{
    class Owner
    {
        private String name;

        private String surname;

        private String phoneNumber;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public String PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Owner(String name, String surname, String phoneNumber) 
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return "Name: " + name + " Surname: " + surname + " phone number: " + phoneNumber;
        }

    }
}
