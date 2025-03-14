int eggsFirst = int.Parse(Console.ReadLine());
int eggsSecond = int.Parse(Console.ReadLine());
string command = Console.ReadLine();

while(command!="End")
{

    if(command=="one")
    {
        eggsSecond --;
    }
    else if(command=="two")
    {
        eggsFirst --;
    }
    if(eggsFirst == 0)
    {
        Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecond} eggs left.");
        break;
    }
    else if(eggsSecond==0)
    {
        Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirst} eggs left.");
        break;
    }
    command = Console.ReadLine();
    if (command == "End")
    {
        Console.WriteLine($"Player one has {eggsFirst} eggs left.");
        Console.WriteLine($"Player two has {eggsSecond} eggs left.");
        break;

    }
   
}


