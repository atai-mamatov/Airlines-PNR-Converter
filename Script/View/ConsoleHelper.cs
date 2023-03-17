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

            //string pattern = @"^TS\s\d{3}\s[A-Z]\s\d{2}[A-Z]{3}\s\d\s[A-Z]{3}[A-Z]{3}\sHK\d\s+\d{4}\s+\d{4}\s+[A-Z]\s\d$";
            ////TS 275 J 15OCT 4 LGWYVR HK1         1010 1200   332 E 0

            //if (!System.Text.RegularExpressions.Regex.IsMatch(value, pattern))
            //{
            //    throw new FormatException();
            //}

            return value;
        }


        public static void PrintAirlineName(string airlineCode)
        {
            // Загрузка данных из файла в словарь
            var airlineDictionary = File.ReadAllLines("C:\\Users\\TUF\\Desktop\\C# Codes\\Script\\Script\\bin\\Debug\\net6.0\\View\\aircompanies.txt")
                .Select(line => line.Split(","))
                .ToDictionary(fields => fields[1].Trim(), fields => fields[0].Trim());

            // Проверка, есть ли значение в словаре и вывод соответствующего ему названия авиалинии
            if (airlineDictionary.TryGetValue(airlineCode, out var airlineName))
            {
                Console.WriteLine($"Название авиалинии: {airlineName}");
            }
            else
            {
                Console.WriteLine("Авиалиния не найдена.");
            }
        }


        public static void FindCity(string airportCode)
        {
            string filePath = "airports.txt";
            var airportDictionary = File.ReadAllLines("C:\\Users\\TUF\\Desktop\\C# Codes\\Script\\Script\\bin\\Debug\\net6.0\\View\\airports.txt")
                .Select(line => line.Split('\t'))
                .ToDictionary(fields => fields[0].Trim(), fields => fields[1].Trim());

            string departureCity = "";
            string arrivalCity = "";
            if (airportDictionary.TryGetValue(airportCode.Substring(0, 3), out departureCity) && airportDictionary.TryGetValue(airportCode.Substring(3), out arrivalCity))
            {
                Console.WriteLine($"Город вылета: {departureCity}");
                Console.WriteLine($"Город прилета: {arrivalCity}");
            }
            else
            {
                Console.WriteLine("Аэропорт не найден.");
            }
        }









        //public static void PrintCity(string iataCode)
        //{
        //    // Загрузка данных из файла в словарь
        //    var cityCountryDictionary = File.ReadAllLines("C:\\Users\\TUF\\Desktop\\C# Codes\\Script\\Script\\bin\\Debug\\net6.0\\View\\airports.txt")
        //        .Select(line => line.Split(' '))
        //        .ToDictionary(fields => fields[0], fields => fields[1]);

        //    // Проверка, есть ли значение в словаре и вывод соответствующего названия города
        //    if (cityCountryDictionary.TryGetValue(iataCode, out var city))
        //    {
        //        Console.WriteLine($"Город: {city}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Код IATA не найден в файле.");
        //    }
        //}





        //public static string GetDateAndMonth()



    }
}
