using Script.Data.Database.SqlServer;
using Script.Data;
using Microsoft.Data.SqlClient;
using Script.View;

//using var db = new AppDbContext();
//db.AddDataFromFiles(@"View\aircompanies.txt");

string pnr = null;
bool valid = false;
string[] fields = null;

while (!valid)
{
    try
    {
        pnr = ConsoleHelper.GetFlightCodeFromConsole("PNR");
        Console.WriteLine($"Вы ввели: {pnr}");
        fields = pnr.Split(' '); // Split the PNR string into an array of fields using the space character as a delimiter
        valid = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Строка не соответствует нужному формату. Пожалуйста, введите строку заново.");
    }
}

string bookingNumber = fields[0]; // Extract the booking number
string airlineCode = fields[1]; // Extract the airline code
string flightNumber = fields[2]; // Extract the flight number
string bookingClass = fields[3]; // Extract the booking class
string departureDate = fields[4]; // Extract the departure date
string departureDayOfWeek = fields[5]; // Extract the departure day of week
string origin = fields[6]; // Extract the origin airport code
string destination = fields[7]; // Extract the destination airport code
string flightStatus = fields[8]; // Extract the flight status
string departureTime = fields[9]; // Extract the departure time
string arrivalTime = fields[10]; // Extract the arrival time
string aircraftType = fields[11]; // Extract the aircraft type
string mealCode = fields[12]; // Extract the meal code



Console.WriteLine(fields);