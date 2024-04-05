using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoForce
{
    public class ClientFuncions
    {        
        protected List<string> clientList { get; set; }

        public ClientFuncions() 
        {
            clientList = new List<string>();
        }

        public void insertClient(string _name)
        {
            if (_name != "")
            {
                clientList.Add(_name);
            }
            else
            {
                Console.WriteLine("Name cannot be null!");
            }
        }

        public void consultListClients()
        {
            for (int i = 0; i < clientList.Count(); i++)
            {
                Console.WriteLine(i + 1 + " - " + clientList[i]);
            }
        }

        public void deleteClient()
        {
            int idClient = 0;
            int confirmDelete = 0;
                                    
            Console.WriteLine("Please, insert the id's client you want to delete");
            Console.WriteLine("Type 0 to exit");

            this.consultListClients();

            idClient = Convert.ToInt32(Console.ReadLine());

            if (idClient != 0)
            {
                for (int i = 0; i < clientList.Count(); i++)
                {
                    if (idClient == i + 1)
                    {
                        Console.WriteLine($"Are you shure you want to remove {clientList[i]} ?");

                        Console.WriteLine("1-Yes");
                        Console.WriteLine("0-No");

                        confirmDelete = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            if (confirmDelete == 1)
                            {
                                clientList.RemoveAt(i);
                            }
                            else if (confirmDelete == 0)
                            {
                                Console.WriteLine("Bye");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Options!");
                            }
                        } while ((confirmDelete != 0) && (confirmDelete != 1));
                    }
                }
            }            
        }

        public void updateClient()
        {
            int idClient = 0;
            int confirmDelete = 0;

            Console.WriteLine("Please, insert the id's client you want to delete");
            Console.WriteLine("Type 0 to exit");

            this.consultListClients();

            idClient = Convert.ToInt32(Console.ReadLine());

            if (idClient != 0)
            {
                for (int i = 0; i < clientList.Count(); i++)
                {
                    if (idClient == i + 1)
                    {
                        Console.WriteLine($"Are you shure you want to edit {clientList[i]} ?");

                        Console.WriteLine("1-Yes");
                        Console.WriteLine("0-No");

                        confirmDelete = Convert.ToInt32(Console.ReadLine());

                        do
                        {
                            if (confirmDelete == 1)
                            {
                                clientList[i] = Console.ReadLine();
                            }
                            else if (confirmDelete == 0)
                            {
                                Console.WriteLine("Bye");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Options!");
                            }

                        } while ((confirmDelete != 0) && (confirmDelete != 1));
                    }

                }
            }
        }
    }
}
