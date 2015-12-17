using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iDNum;          //Identification Number
            string fName;       //First Name
            string lName;       //Last Name
            string school;      //School
            string state;       //State
            string email;       //Email
            int yJoined;        //Year Joined
            bool active;        //User Activity
            int amOwed;         //Amount Owed

            bool newUser;

            Console.Write ("new user?");
            Console.Write("Y/N  ?");
            if (Console.ReadLine())  {
                newUser = true;
            }
            else
            {
                Console.Write ("Ok");
            }
            Console.ReadKey ();
        }
    }
}
