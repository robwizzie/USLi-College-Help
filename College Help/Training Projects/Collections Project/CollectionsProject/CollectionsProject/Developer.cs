using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class Developer
    {
        public string firstName;
        public string lastName;
        public string phoneExtension;
        public string gender;
        public string fullName;

        public Developer(string firstName, string lastName, string phoneExtension, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneExtension = phoneExtension;
            this.gender = gender;

            
        }
       
        public override string ToString()
        {
            fullName = firstName + " " + lastName;

            return fullName + " " + phoneExtension;
        }
    }
}
