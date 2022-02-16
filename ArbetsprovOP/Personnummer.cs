using log4net;
using System.Collections.Generic;

namespace ArbetsprovOP
{
    public class Personnummer
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int[] GetNumber(string text)
        {

            var pn = new List<int>();

            foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(text, @"\d"))
            {
                pn.Add(int.Parse(match.Value));
            }
            return pn.ToArray();
        }

        public bool IsValid(int[] number)
        {

            int sum = 0;
            bool control = false;
            for (int i = 0; i < 10; i++)
            {


                if (control == false)
                {
                    number[i] *= 2;
                }

                if (number[i] > 9)
                {
                    number[i] -= 9;

                }

                sum += number[i];

                control = !control;

            }

            return sum % 10 == 0;


        }
    }
}