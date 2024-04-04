using System;
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
            ClientFuncions clientFunctions;

            List<string> clientList = new List<string>();
            int menuIterator = 0;            
                       
            do
            {
                Console.WriteLine("________________________________");
                Console.WriteLine("Choose one option");
                Console.WriteLine("1-Register Client");
                Console.WriteLine("2-Show client List");
                Console.WriteLine("3-Edit Client");
                Console.WriteLine("4-Delete Client");
                Console.WriteLine("0-Exit");
                Console.WriteLine("________________________________");

                menuIterator = Convert.ToInt32(Console.ReadLine());

                menusValidator = new MenusValidator(menuIterator);

                if (!menusValidator.validateCrudOperator())
                {
                    clientFunctions = new ClientFuncions();

                    switch (menuIterator)
                    {
                        case 1:
                            Console.WriteLine("User Register");

                            clientFunctions.insertClient(Console.ReadLine());
                            clientFunctions.consultListClients();

                            break;
                        case 2:

                            clientFunctions.consultListClients();

                            break;
                        case 3:
                            Console.WriteLine("User deleted");
                            break;
                        case 0:
                            Console.WriteLine("Bye");
                            break;
                    }
                }
            } while (menuIterator != 0);            
        }
    }
}
