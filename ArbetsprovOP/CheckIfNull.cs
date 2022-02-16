using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbetsprovOP
{
    public class CheckIfNull
    {
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
