﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoForce
{
    class MenuFunctionalities
    {        
        public static void mainFuncionalities()
        {
            MenusValidator menusValidator;
            
            int menuIterator = 0;
            
            Console.WriteLine("-----System Functionalities-----");
            Console.WriteLine("1-Register user");
            Console.WriteLine("2-Update user");
            Console.WriteLine("3-Delete user");
            Console.WriteLine("0-Exit");

            menuIterator = Convert.ToInt32(Console.ReadLine());
                        
            menusValidator = new MenusValidator(menuIterator);

            if (!menusValidator.validateCrudOperator())
            {
                do
                {
                    switch (menuIterator)
                    {
                        case 1:
                            Console.WriteLine("User Register");
                            break;
                        case 2:
                            Console.WriteLine("User updated");
                            break;
                        case 3:
                            Console.WriteLine("User deleted");
                            break;
                        case 0:
                            Console.WriteLine("Bye");
                            break;
                    }
                } while (menuIterator != 0);
            }
        }
    }
}
