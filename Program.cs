// SE145 / Lab4 / Part 3 / Walid AMAR / Week 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE245_LAB4_wamar_Part3
{
    class Program
    {
        // Public Class
        public class Person 
        {
            private string FName, MName, LName, Street1, Street2, City, State, Zip, Phone, Email;

            public string fName
            {
                get
                {
                    return FName;
                }
                set
                {
                    FName = value;
                }

            }
            public string mName
            {
                get
                {
                    return MName;
                }
                set
                {
                    MName = value;
                }

            }
            public string lName
            {
                get
                {
                    return LName;
                }
                set
                {
                    LName = value;
                }

            }
            public string street1
            {
                get
                {
                    return Street1;
                }
                set
                {
                    Street1 = value;
                }

            }
            public string street2
            {
                get
                {
                    return Street2;
                }
                set
                {
                    Street2 = value;
                }

            }
            public string city
            {
                get
                {
                    return City;
                }
                set
                {
                    City = value;
                }

            }
            public string state
            {
                get
                {
                    return State;
                }
                set
                {
                    State = value;
                }

            }
            public string zip
            {
                get
                {
                    return Zip;
                }
                set
                {
                    Zip = value;
                }

            }
            public string phone
            {
                get
                {
                    return Phone;
                }
                set
                {
                    Phone = value;
                }

            }
            public string email
            {
                get
                {
                    return Email;
                }
                set
                {
                    Email = value;
                }

            }
        }


        // Pause function
        static void Pause()
        {
            Console.WriteLine(" Press any key to exit. ");
            Console.ReadKey();
        }
        //Main Loop
        static void Main(string[] args)
        {

            Person temp = new Person();

            // User's input
            Console.Write("     Hello !");
            Console.Write("\n \n     Please enter the following informations :");
            Console.Write("\n \n First Name : ");
            temp.fName = Console.ReadLine() + " Poopy";
            Console.Write(" Middle Name : ");
            temp.mName = Console.ReadLine();
            Console.Write(" Last Name : ");
            temp.lName = Console.ReadLine();
            Console.Write(" Street 1 : ");
            temp.street1 = Console.ReadLine();
            Console.Write(" Street 2 : ");
            temp.street2 = Console.ReadLine();
            Console.Write(" City : ");
            temp.city = Console.ReadLine();
            Console.Write(" State : ");
            temp.state = Console.ReadLine();
            Console.Write(" Zip : ");
            temp.zip = Console.ReadLine();
            Console.Write(" Phone Number : ");
            temp.phone = Console.ReadLine();
            Console.Write(" Email : ");
            temp.email = Console.ReadLine();

            //Output
            Console.WriteLine("\n \n Here is your person's information : ");
            Console.WriteLine(" First Name : " + temp.fName);
            Console.WriteLine(" Middle Name : " + temp.mName);
            Console.WriteLine(" Last Name : " + temp.lName);
            Console.WriteLine(" Street 1 : " + temp.street1);
            Console.WriteLine(" Street 2 : " + temp.street2);
            Console.WriteLine(" City : " + temp.city);
            Console.WriteLine(" State : " + temp.state);
            Console.WriteLine(" Zip : " + temp.zip);
            Console.WriteLine(" Phone : " + temp.phone);
            Console.WriteLine(" Email : " + temp.email);
            Pause();
        }
    }
}
