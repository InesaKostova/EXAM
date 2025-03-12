﻿double buget = double.Parse(Console.ReadLine());
string destination =Console.ReadLine();
string season =Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double priceForOneDay = 0;
if (destination == "Dubai")
{
    if (season == "Winter")
    {
        priceForOneDay = 45000*0.7;
    }
    else if (season == "Summer")
    {
        priceForOneDay = 40000*0.7;
    }

}
else if (destination == "Sofia")
{
    if (season == "Winter")
    {
        priceForOneDay = 17000 *1.25;
    }
    else if (season == "Summer")
    {
        priceForOneDay = 12500 *1.25;
    }
}
else if (destination == "London")
{
    if (season == "Winter")
    {
        priceForOneDay = 24000;
    }
    else if (season == "Summer")
    {
        priceForOneDay = 20250;
    }
}
    
 double finalPrice = days * priceForOneDay;

if(finalPrice<=buget)
{
    Console.WriteLine($"The budget for the movie is enough! We have {buget-finalPrice:F2} leva left!");

}
else
{
    Console.WriteLine($"The director needs {finalPrice-buget:F2} leva more!");
}
