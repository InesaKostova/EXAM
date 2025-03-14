string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

int num1First = int.Parse(num1[0].ToString());
int num1Second = int.Parse(num1[1].ToString());
int num1Third = int.Parse(num1[2].ToString());
int num1Fourth = int.Parse(num1[3].ToString());

int num2First = int.Parse(num2[0].ToString());
int num2Second = int.Parse(num2[1].ToString());
int num2Third = int.Parse(num2[2].ToString());
int num2Fourth = int.Parse(num2[3].ToString());

for (int i = num1First; i <= num2First; i++)
{
    for (int j = num1Second; j <= num2Second; j++)
    {
        for (int k = num1Third; k <= num2Third; k++)
        {
            for (int l = num1Fourth; l <= num2Fourth; l++)
            {
                if (i % 2 == 1 && j % 2 == 1 && k % 2 == 1 && l % 2 == 1)
                {
                    Console.Write($"{i}{j}{k}{l} ");
                }
            }
        }
    }
}
