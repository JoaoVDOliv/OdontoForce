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
            ClientFuncions clientFunctions =  new ClientFuncions();

            int menuIterator = 0;

            do
            {
                Console.WriteLine("________________________________");
                Console.WriteLine("Choose one option");
                Console.WriteLine("1-Register Client");
                Console.WriteLine("2-Show client List");
                Console.WriteLine("3-Delete Client");
                Console.WriteLine("4-Edit Client");
                Console.WriteLine("0-Exit");
                Console.WriteLine("________________________________");

                menuIterator = Convert.ToInt32(Console.ReadLine());                

                switch (menuIterator)
                {
                    case 1:
                        Console.WriteLine("Write the client name: ");

                        clientFunctions.insertClient(Console.ReadLine());                        
                        break;
                    case 2:                        
                        Console.WriteLine("List of clients:");

                        clientFunctions.consultListClients();
                        break;
                    case 3:
                        
                        clientFunctions.deleteClient();
                        break;
                    case 4:

                        clientFunctions.updateClient();
                        break;
                    case 0:

                        Console.WriteLine("Bye");
                        break;
                        
                    default:
                        Console.WriteLine("Invalid option!");
                        Console.WriteLine("Please, choose beetwen one option of navegation");
                    break;                    
                }
            } while (menuIterator != 0);            
        }
    }
}
