using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step165
{
    public class Person
    {
        public void PersonName(string FirstName, string LastName)
        {
            string FullName = FirstName + " " + LastName;
            SayName();

            void SayName()
            {
                Console.WriteLine("Name:" + FullName);
            }
        }
    }
}
