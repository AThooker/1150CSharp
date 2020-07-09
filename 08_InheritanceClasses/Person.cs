using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_InheritanceClasses
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        public string Name
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                return (!string.IsNullOrEmpty(fullName)) ? fullName : "Unnamed";
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public void SetFirstName(string name)
        {
            _firstName = name;
        }
        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
