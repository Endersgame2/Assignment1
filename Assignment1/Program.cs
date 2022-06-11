int num20 = 20;
int num10 = 10;
int num5 = 5;
int num2 = 2;
int num1 = 1;

int counter = 0;
Console.WriteLine("How much money you want to enter");
int inputMoney = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("How much you want to buy");
int purchase = Convert.ToInt32(Console.ReadLine());


// algrorith
int result = Convert.ToInt32(inputMoney - purchase);

Console.WriteLine("The user entered $"+inputMoney+" and wants to buy a $"+purchase+"");

for (int i = 0; i < result; i++)
{
    if (result % num20 == 0)
    {
        int resultDividebyTwo = result / num20;
        Console.WriteLine($"So I should return you {resultDividebyTwo} $20 bill.");
        break;
    }

    if (result % num10 == 0)
    {
        int resultDividebyTwo = result / num10;
        Console.WriteLine($"So I should return you {resultDividebyTwo} $10 bill.");
        break;
    }

    if (result % num5 == 0)
    {
        int resultDividebyTwo = result / num5;
        Console.WriteLine($"So I should return you {resultDividebyTwo} $5 bill.");
        break;
    }

    if (result % num2 == 0)
    {
        int resultDividebyTwo = result / num2;
        Console.WriteLine($"So I should return you {resultDividebyTwo} Coins of $2");
        break;
    }

    if (result % num1 == 0)
    {
        int resultDividebyTwo = result / num1;
        Console.WriteLine($"So I should return you {resultDividebyTwo} Coins of $1");
        break;
    }


}


