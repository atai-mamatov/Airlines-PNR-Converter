using Script.View;
using System;



string pnr = null;
bool valid = false;
string[] fields = null;

while (!valid)
{
    try
    {
        char[] separator = { ' ' };
        Console.Write("Введите PNR: ");
        pnr = Console.ReadLine().ToUpper();
        Console.WriteLine($"Вы ввели: {pnr}");
        fields = pnr.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        if (fields.Length != 13) throw new FormatException();
        valid = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Строка не соответствует нужному формату. Пожалуйста, введите строку заново.");
    }
}

string bookingNumber = fields[0];
string airlineCode = fields[1];
string flightNumber = fields[2];
string bookingClass = fields[3];
string departureDate = fields[4];
string departureDayOfWeek = fields[5];
string origin = fields[6];
string destination = fields[7];
string flightStatus = fields[8];
string departureTime = fields[9];
string arrivalTime = fields[10];
string aircraftType = fields[11];
string mealCode = fields[12];

Dictionary<string, string> months = new Dictionary<string, string>();
months.Add("JAN", "Январь");
months.Add("FEB", "Февраль");
months.Add("MAR", "Март");
months.Add("APR", "Апрель");
months.Add("MAY", "Май");
months.Add("JUN", "Июнь");
months.Add("JUL", "Июль");
months.Add("AUG", "Август");
months.Add("SEP", "Сентябрь");
months.Add("OCT", "Октябрь");
months.Add("NOV", "Ноябрь");
months.Add("DEC", "Декабрь");

string departureMonthCode = departureDate.Substring(2, 3);
string departureMonth = months[departureMonthCode];


ConsoleHelper.PrintAirlineName(airlineCode);
ConsoleHelper.FindCity(origin);
ConsoleHelper.FindCity(destination);





string dayOfMonth = departureDate.Substring(0, 2);
Console.Write($"День месяца: {dayOfMonth},\n" +
    $"Месяц вылета: {departureMonth}");
Console.Write($"Код авиакомпании: {airlineCode}, ");

Console.Write($"Номер рейса: {flightNumber}, ");
Console.Write($"Дата вылета: {departureDate}, ");
Console.Write($"Аэропорт отправления: {origin}, ");
Console.Write($"Аэропорт прибытия: {destination}, ");
Console.Write($"Время вылета: {departureTime}, ");
Console.Write($"Время прибытия: {arrivalTime}, ");
Console.Write($"Код питания: {mealCode}, ");
Console.WriteLine();



























//string pnr = null;
//bool valid = false;
//string[] fields = null;

//while (!valid)
//{
//    try
//    {
//        char[] separator = { ' ' };
//        pnr = ConsoleHelper.GetFlightCodeFromConsole("PNR");
//        Console.WriteLine($"Вы ввели: {pnr}");
//        fields = pnr.Split(separator,StringSplitOptions.RemoveEmptyEntries); // Split the PNR string into an array of fields using the space character as a delimiter
//        if (fields.Length != 13) throw new FormatException();
//        valid = true;
//        //TS 275 J 15OCT 4 LGWYVR HK1         1010 1200   332 E 0
//        //AC 8097 Y 15OCT 4 YVRSEA HK1         1335 1435   DH4 E 0
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Строка не соответствует нужному формату. Пожалуйста, введите строку заново.");
//    }
//}

//string bookingNumber = fields[0]; // Extract the booking number
//string airlineCode = fields[1]; // Extract the airline code
//string flightNumber = fields[2]; // Extract the flight number
//string bookingClass = fields[3]; // Extract the booking class
//string departureDate = fields[4]; // Extract the departure date
//string departureDayOfWeek = fields[5]; // Extract the departure day of week
//string origin = fields[6]; // Extract the origin airport code
//string destination = fields[7]; // Extract the destination airport code
//string flightStatus = fields[8]; // Extract the flight status
//string departureTime = fields[9]; // Extract the departure time
//string arrivalTime = fields[10]; // Extract the arrival time
//string aircraftType = fields[11]; // Extract the aircraft type
//string mealCode = fields[12]; // Extract the meal code


//Dictionary<string, string> months = new Dictionary<string, string>();

//months.Add("JAN", "Январь");
//months.Add("FEB", "Февраль");
//months.Add("MAR", "Март");
//months.Add("APR", "Апрель");
//months.Add("MAY", "Май");
//months.Add("JUN", "Июнь");
//months.Add("JUL", "Июль");
//months.Add("AUG", "Август");
//months.Add("SEP", "Сентябрь");
//months.Add("OCT", "Октябрь");
//months.Add("NOV", "Ноябрь");
//months.Add("DEC", "Декабрь");




//Console.WriteLine(months[]);