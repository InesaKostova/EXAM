double buget = double.Parse(Console.ReadLine());
int countNights = int.Parse(Console.ReadLine());
double pricePerOneNight = double.Parse(Console.ReadLine());
double percentForSpend = int.Parse(Console.ReadLine());
if (countNights > 7)
{
    pricePerOneNight = pricePerOneNight * 0.95;
}

double pricePerNights = countNights * pricePerOneNight;
double sumForSpend = buget * (percentForSpend / 100);
double finalSum = pricePerNights + sumForSpend;
if (finalSum <= buget)
{
    Console.WriteLine($"Ivanovi will be left with {buget - finalSum:F2} leva after vacation.");
}
else if(finalSum>buget)
{
    Console.WriteLine($"{finalSum - buget:F2} leva needed.");
}

