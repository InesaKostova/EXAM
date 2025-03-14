int days = int.Parse(Console.ReadLine());
double fullFood = double.Parse(Console.ReadLine());
double biscuits = 0;
double eatenDogFood = 0;
double eatenCatFood = 0;

for(int currentDay=1;currentDay<=days;currentDay++)
{
    int foodDog = int.Parse(Console.ReadLine());
    int foodCat = int.Parse(Console.ReadLine());
   eatenDogFood += foodDog;
    eatenCatFood += foodCat;

    if(currentDay%3==0)
    {
        biscuits+=(foodDog+foodCat)*0.1;
    }

}
double foodEaten = eatenDogFood + eatenCatFood;
Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
Console.WriteLine($"{(foodEaten/fullFood)*100:F2}% of the food has been eaten.");
Console.WriteLine($"{(eatenDogFood/foodEaten)*100:F2}% eaten from the dog.");
Console.WriteLine($"{(eatenCatFood/foodEaten)*100:F2}% eaten from the cat.");
