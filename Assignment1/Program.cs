﻿// Question 1 
// Here it will pompt the user for Input of his  total money
// Then it will make a simple subtraction from what he wants to buy by his input.
// algorithm works as: it has some special change values i.e 20,10 etc...
// it has a count which will divide the subtracted amount with the change where we run a loop of our values which fix we get that out.
// in loop we will simply check if its a non zero and then in condition we will simply match the modules from 20 and the result will be sent back again and then modules untill it becomes 0;
// if got time I will work on quantity of dollars.


// Simple Prompt
Console.WriteLine("How much money you want to enter");
int inputMoney = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How much you want to buy");
int purchase = Convert.ToInt32(Console.ReadLine());


// algrorith
int[] change = { 20, 10, 5, 2, 1 };
int result = Convert.ToInt32(inputMoney - purchase);
int count;
Console.WriteLine("The user entered $" + inputMoney + " and wants to buy a $" + purchase + "");

for (int i = 0; i < change.Length; i++)
{
    count = result / change[i];
    if (result!= 0)
    {
        result %= change[i];
        Console.WriteLine(change[i]+": piece "+ count);
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