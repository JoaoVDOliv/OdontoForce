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

        /// <summary>
        /// This method will verify the characteres.
        /// </summary>
        public int validateNoYesOperator()
        {
            bool notValid = true;

            if ((menuInteractor == 1) || (menuInteractor == 0))            
            {
                return menuInteractor;
            }
            else
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
    
        public bool validateCrudOperator()
        {
            bool notValid = true;

            if ((menuInteractor == 1) || (menuInteractor == 2) || (menuInteractor == 3) || (menuInteractor == 0))
            {
                return notValid = false;
            }
            else
            {
                while (notValid)
                {
                    Console.WriteLine("The options of operator is wrong!");
                    Console.WriteLine("Please, choose 1, 2, 3 or 0 for client options");

                    menuInteractor = Convert.ToInt32((Console.ReadLine()));

                    notValid = (menuInteractor == 1) || (menuInteractor == 2) || (menuInteractor == 3) || (menuInteractor == 0)
                        ? false : true;
                }
            }

            return notValid;
        }
    }
}
