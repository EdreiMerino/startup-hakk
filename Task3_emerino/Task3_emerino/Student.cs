using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a class 'Student'

// Child class of 'Person'

namespace Task3_emerino
{
    public class Student : Person // 'Student' class inherits from 'Person' class.
    {
        // method members

        // "I'm studying" will be displayed on the screen using the 'public Study() function' 
        // of the 'Student' class.
        public string Study()
        {
            return "I'm studying";
        }

        public string ShowAge(int age)
        {
            return "My age is " + age + " years old.";
        }
    }
}
