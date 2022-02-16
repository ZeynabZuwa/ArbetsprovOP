using log4net;
using System.Collections.Generic;

namespace ArbetsprovOP
{
    public class Personnummer
    {

        /// <summary>
        /// This is a method that takes a text string and turns it into an array of integers.
        /// First it creates an emty list with integers. then in the forech it goes through all the matches
        /// in the text using a Regular Expressions @"\d" which means that it goes through all the numbers.
        /// And foreach number in the string it will parse and convert the string representation of a number to an int.
        /// </summary>
        /// <param name="text"> That is the string of number the user will input</param>
        /// <returns>The string that we put into an array of int</returns>
        public int[] GetNumber(string text)
        {
            var pn = new List<int>();

            foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(text, @"\d"))
            {
                pn.Add(int.Parse(match.Value));
            }
            return pn.ToArray();
        }

        /// <summary>
        /// This method will take in an array of numbers and then loop through each number in the
        /// mathematical expression below. So The first number of the array
        /// starts with being false and that means
        /// that the number will be multiplied with 2. If that number is greater than 10 the number will be
        /// subtracted with 9. The final number will be added to the sum. The next number in the array is now true
        /// so that means it will not be added with 2. That number will be added to the sum. the third number will
        /// be false so it will be multiplied with 2. if the number becomes gretaer then 10 it will be substracted
        /// with 9. If not the number will have the same value. And that number will be added to the sum.
        /// 
        /// This will happen 10 times and after that the sum will be moduloed to see if the remainder equals to
        /// 0. If it equals to 0 than the "personnummer" vill be true, if it is not equal to 0 then it is false.
        /// </summary>
        /// <param name="number">That is the array of numbers that will be checked in the method</param>
        /// <returns>Returns a true if the swedish social security is OK or false if it's Not Ok</returns>

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