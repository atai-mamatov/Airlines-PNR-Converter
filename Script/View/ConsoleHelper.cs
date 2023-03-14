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
            Console.WriteLine($"Please enter {fieldName}");
            string value = Console.ReadLine();
            if (value == " " || value == "") throw new Exception();

            return value;
        }
    }
}
