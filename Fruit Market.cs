double strawberryPrice = double.Parse(Console.ReadLine());
double countBanana=double.Parse(Console.ReadLine());
double countOrange = double.Parse(Console.ReadLine());
double countBerry= double.Parse(Console.ReadLine());
double countStrawberry = double.Parse(Console.ReadLine());


double berryPrice = strawberryPrice / 2;
double orangePrice = berryPrice - (berryPrice * 0.4);
double bananaPrice = berryPrice - (berryPrice * 0.8);

double sum=(countStrawberry*strawberryPrice)+(countBanana*bananaPrice)+(countOrange*orangePrice)+(countBerry*berryPrice);


Console.WriteLine($"{sum:F2}");