//Roadtrip
Console.WriteLine("What is the round trip in miles");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many miles per gallon?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("what is the price of gas per gallon?");
double fuelCost = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roundTripMiles / (double)milesPerGallon;

double totalCost = gallonsNeeded * fuelCost;

Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + totalCost.ToString("C"));

//Pizza party
Console.WriteLine("How many people are going?");
int guestList = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many pizzas?");
int howManyPizza = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Price per pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const int pizzaSlices = 8;


double totalSlices = howManyPizza * pizzaSlices;
double slicesPerPerson = totalSlices / guestList;
double pizzaCost = howManyPizza * pricePerPizza;


Console.WriteLine("Total slices: " + totalSlices.ToString("F1"));
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C")); 

//Paycheck

Console.WriteLine("Hours worked this week?");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Hourly rate?");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double taxRate = .18;

double grossPay = hoursWorked * hourlyRate;
double taxWithHeld = grossPay * taxRate;
double takeHome = grossPay - taxWithHeld;

Console.WriteLine("Gross pay: " + grossPay.ToString("F2"));
Console.WriteLine("Tax withheld: " + taxWithHeld.ToString("F2"));
Console.WriteLine("Take home pay: " + takeHome.ToString("F1"));

//Whole Trip

double tripTotal = totalCost + pizzaCost;
double costPerPerson = totalCost / guestList;
double takeHomePayPerHour = takeHome / hoursWorked;
double hoursMustWork = costPerPerson / takeHomePayPerHour;

Console.WriteLine("Trip total: " + tripTotal.ToString("C"));  
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));  
Console.WriteLine("Take home pay: " + takeHomePayPerHour.ToString("C"));  
Console.WriteLine("Hours you must work: " + hoursMustWork.ToString("F2"));