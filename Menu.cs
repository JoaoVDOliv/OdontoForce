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
            MenusValidator menusValidator;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Welcome to OdontForce");
            Console.WriteLine("Do you want start the operations?");
            Console.WriteLine("1-Yes");
            Console.WriteLine("0-No");
            Console.WriteLine("-------------------------------------------");

            menusValidator = new MenusValidator(Convert.ToInt32(Console.ReadLine()));
            
            if (menusValidator.validateNoYesOperator() == 1)
            {
                Console.WriteLine("Dentist Worker");
                
                MenuFunctionalities.mainFuncionalities();
            }
            else
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
