using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArbetsprovOP
{
    /// <summary>
    /// Using Regular Expressions (Regex) to write down my conditions. If you look at
    /// Registration number you can see that I first wrote [A-Z]{3}. This means that the first
    /// 3 characters must be uppercase letters between A-Z. And the other 3 characters must be
    /// between the number 0-9 which is represented in the code like this [0-9]{3}.
    /// </summary>
    public class CarRegistrationNumber
    {
        public static string RegistrationNumber = "^[A-Z]{3}[0-9]{3}$";

        public bool ValidateReg(string reg)
        {
            return Regex.IsMatch(reg, RegistrationNumber);
        }
    }
}
