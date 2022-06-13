
Console.WriteLine("How much money you want to enter");
int inputMoney = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("How much you want to buy");
int purchase = Convert.ToInt32(Console.ReadLine());


// algrorith

int result = Convert.ToInt32(inputMoney - purchase);
int count;
Console.WriteLine("The user entered $" + inputMoney + " and wants to buy a $" + purchase + "");
Console.WriteLine(result);
int[] change = { 20, 10, 5, 2, 1 };

for (int i = 0; i < change.Length; i++)
{
    count = result / change[i];
    if (result!= 0)
    {
        Console.WriteLine(" I will return {0}$ :{1} ", change[i] , count);
        result %= change[i];
    }

}



//*****************************************************************************************************
// Question 2
//*****************************************************************************************************


//Console.WriteLine("Please Enter a String in Upper Case");
//string input = Console.ReadLine();
//char[] arr= input.ToCharArray();

//var dict = new Dictionary<char, int>();
//foreach (char c in arr)
//{
//    if (dict.ContainsKey(c))
//    dict[c]++;
//    else
//        dict[c]=1;
//}
//foreach (var c in dict)
//{
//    Console.WriteLine(c);
//}

// Just need to get this c Condition 
// if(c > 2)
//{
//    // int count should be replaced by charac escept 1 index of it.
// 1 index should be simply appended with the count
//}