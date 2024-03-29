using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoForce
{
    public class RegisterClient
    {
        protected string name { get; set; }        
        protected List<string> listClient = new List<string>();

        public RegisterClient(string _name = "") 
        {            
            RegisterClient registerClient = new RegisterClient();
            
            if (_name != "")
            {
                registerClient.insertClient();
            }
        }
        
        public void insertClient()
        {
            Console.WriteLine("Name: ");
            
            this.name = Console.ReadLine();

            Console.WriteLine("The name is " + this.name);
        }
    }
}
