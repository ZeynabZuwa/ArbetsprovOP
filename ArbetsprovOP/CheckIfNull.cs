using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbetsprovOP
{
    public class CheckIfNull
    {
        /// <summary>
        /// This method checks if the user input is a string or null.
        /// </summary>
        /// <param name="message">That is the string input that the user put in. It is either a string or null</param>
        public static void IfNull(string message)
        {
            if (message is null)
            {
                Console.WriteLine("The value is null");
                
            }
            else if (message is not null)
            {
                Console.WriteLine($" The value is: {message}");
            }
        }
    }
}
