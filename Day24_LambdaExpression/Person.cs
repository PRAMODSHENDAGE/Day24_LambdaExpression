using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_LambdaExpression
{
    internal class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }

        public Person(string firstname, string lastname, string email, string mobile, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.mobile = mobile;
            this.password = password;
        }
    }
}
