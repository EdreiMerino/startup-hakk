using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a class 'Person'

// The 'Person' class is an ancestor of the 'Student' and 'Professor' classes.

namespace Task3_emerino
{
    public class Person
    {
        // field members (data?)
        private string FirstName = "Edrei";
        private string LastName = "Merino";


        // method members  

        // Create two public methods, "Greet()" and "SetAge(int age)", that will assign
        // the person's age.
        public string Greet()
        {
            return "Hello!";
        }

        public int SetAge(int age)
        {
            return age;
        }
    }
}
