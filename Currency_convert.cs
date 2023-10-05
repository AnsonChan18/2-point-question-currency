using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_convert__2_points_
{
    internal class Program
    {
        //define the subroutine
        static void _currency()
        {
            //display the conversion rates
            Console.WriteLine("GBP --> USD x 1.22");
            Console.WriteLine("GBP --> EURO x 1.16");
            Console.WriteLine("GBP --> YUAN x 8.76");
            Console.WriteLine("GBP --> YEN x 181.02");


            //prompt the user to enter the amount to convert
            Console.WriteLine("Enter the amount in pounds to convert: ");

            //read and write the input as a float
            float _FL_pounds = float.Parse(Console.ReadLine());

            //prompt the user to enter the currency
            Console.WriteLine("Enter the currency to convert into: ");

            //read and write the input as a string
            string _Currency = Console.ReadLine();



            //decisions
            //if user input is USD
            if (_Currency == "USD")
            {
                //convert in the output prompt to save lines
                Console.WriteLine("It will be"+ (_FL_pounds*1.22));
            }

            //if user input is EUR0
            else if (_Currency == "EURO")
            {
                Console.WriteLine("It will be" + (_FL_pounds * 1.16));
            }

            //if user input is YUAN
            else if (_Currency == "YUAN")
            {
                Console.WriteLine("It will be" + (_FL_pounds * 8.76));
            }

            //if user input is YEN
            else if ( _Currency == "YEN")
            {
                Console.WriteLine("It will be" + (_FL_pounds * 181.02));
            }

            //if user input is none of the currency
            else
            {
                Console.WriteLine("Invalid currency!");
                //restart the subroutine
                _currency();
            }

        }
        static void Main(string[] args)
        {
            //calls the subroutine
            _currency();
            Console.ReadLine();
        }
    }
}
