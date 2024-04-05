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
            int menuValidator = 0;
                        
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Welcome to OdontForce");
                Console.WriteLine("Do you want start the operations?");
                Console.WriteLine("1-Yes");
                Console.WriteLine("0-No");
                Console.WriteLine("-------------------------------------------");

                menuValidator = Convert.ToInt32(Console.ReadLine());

                switch (menuValidator) 
                {
                    case 0:

                        Console.WriteLine("Good Bye");
                        break;
                    case 1:

                        MenuFunctionalities.mainFuncionalities();
                        break;
                    default:
                        
                        Console.WriteLine("Invalid option!");
                        Console.WriteLine("You must choose beetwen the start operation options");
                        break;
                }                
            } while (menuValidator != 0);
        }
    }
}
