using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script.View
{
    public class ConsoleHelper
    {

        public static string GetFlightCodeFromConsole(string fieldName)
        {
            Console.WriteLine($"Welcome! Please enter your PNR Code for conversion\n" +
                $"Please enter {fieldName}");
            string value = Console.ReadLine();

            string pattern = @"^TS\s\d{3}\s[A-Z]\s\d{2}[A-Z]{3}\s\d\s[A-Z]{3}[A-Z]{3}\sHK\d\s+\d{4}\s+\d{4}\s+[A-Z]\s\d$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(value, pattern))
            {
                throw new FormatException();
            }

            return value;
        }

        //public static string GetDateAndMonth()



    }
}
