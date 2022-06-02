using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_LambdaExpression
{
    internal class Lambda
    {
        public static void ValidateUserEntry(List<Person> listed)
        {
            listed.Add(new Person("Pramod", "Shendage", "shendagepramod@gmail.com", "7852412563", "Sdfe@124"));
            listed.Add(new Person("Rohit", "Jadhav", "Jadhavrohit456@yahoo.com", "8956231452", "Rohit#@!123"));
            listed.Add(new Person("Prajwal", "Daki", "Dakiprajwal.100@yahoo.com", "9658524785", "Daki^%452"));

            Console.WriteLine(listed.ToString());

            listed.ForEach(x => Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t", x.firstname.ToString(), x.lastname.ToString(), x.email.ToString(), x.mobile.ToString(), x.password.ToString()));
        }
    }
}
