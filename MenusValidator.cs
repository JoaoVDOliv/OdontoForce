using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoForce
{
    public class MenusValidator
    {
        protected int menuInteractor {  get; set; }

        public MenusValidator(int _menuIterator)         
        {
            menuInteractor = _menuIterator;
        }

        public int validateOperator()
        {
            bool notValid = true;

            if ((menuInteractor != 1) || (menuInteractor != 0))            
            {
                while (notValid)
                {
                    Console.WriteLine("Please, choose beetwen 0 and 1");

                    menuInteractor = Convert.ToInt32((Console.ReadLine()));

                    notValid = (menuInteractor == 1) || (menuInteractor == 0) ? false : true;
                }
            }
                        
            return menuInteractor; 
        }
    }
}
