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
                Console.WriteLine(clientList[i]);
            }
        }
    }
}
