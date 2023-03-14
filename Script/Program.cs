using Script.View;

//string code = ConsoleHelper.GetFlightCodeFromConsole("Flight Code");
string pnr = "1 TS 275 J 15OCT 4 LGWYVR HK1         1010 1200   332 E 0"; // Example PNR string
string[] fields = pnr.Split(' '); // Split the PNR string into an array of fields using the space character as a delimiter

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

