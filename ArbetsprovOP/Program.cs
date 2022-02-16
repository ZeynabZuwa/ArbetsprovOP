using System;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]

namespace ArbetsprovOP
{
    public class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

  
        static void Main(string[] args)
        {


            Personnummer persnum = new Personnummer();

            Console.WriteLine("Write a swedish social security number with 10 numbers: ");
            string siffror = Console.ReadLine();

            var allasiffror = persnum.GetNumber(siffror);

            if (allasiffror.Length == 10)
            {
                Console.WriteLine($"The swedish social security number {siffror} is " + persnum.IsValid(allasiffror));
                logger.Info($"The swedish social security number {siffror} is " + persnum.IsValid(allasiffror));

                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($" The swedish social security number {siffror} is False");
                logger.Info($" The swedish social security number {siffror} is False");
                Console.WriteLine("");
            }

            CarRegistrationNumber regex = new CarRegistrationNumber();
            Console.WriteLine("Skriv ett reg nummer:");
            string regNum = Console.ReadLine();
            bool validRegNum = regex.ValidateReg(regNum);
            Console.WriteLine($"Registration number {regNum} is: " + validRegNum);
            logger.Info($"Registration number {regNum} is: " + validRegNum);
            Console.WriteLine("");

            string? info = null;

            CheckIfNull.IfNull(info);
            logger.Info("The value is: " + info);





        }
    }
}
