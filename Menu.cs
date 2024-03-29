using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoForce
{
    public class Menu
    {
        public void menu()
        {            
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Welcome to OdontForce");
            Console.WriteLine("Do you want start the operations?");
            Console.WriteLine("1-Yes");
            Console.WriteLine("0-No");
            Console.WriteLine("-------------------------------------------");

            MenusValidator menusValidator = new MenusValidator(Convert.ToInt32(Console.ReadLine()));
            
            if (menusValidator.validateOperator() == 1)
            {
                Console.WriteLine("Dentrist Worker");
            }
            else
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
