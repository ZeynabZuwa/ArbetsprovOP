using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ArbetsprovOP
{
    public class CarRegistrationNumber
    {
        public static string RegistrationNumber = "^[A-Z]{3}[0-9]{3}$";

        public bool ValidateReg(string reg)
        {
            return Regex.IsMatch(reg, RegistrationNumber);
        }
    }
}
