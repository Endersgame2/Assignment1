// Question 1 
// Here it will pompt the user for Input of his  total money
// Then it will make a simple subtraction from what he wants to buy by his input.
// algorithm works as: it has some special change values i.e 20,10 etc...
// it has a count which will divide the subtracted amount with the change where we run a loop of our values which fix we get that out.
// in loop we will simply check if its a non zero and then in condition we will simply match the modules from 20 and the result will be sent back again and then modules untill it becomes 0;
// if got time I will work on quantity of dollars.


//// Simple Prompt
///

//Console.WriteLine("How much money you want to enter");
//int inputMoney = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("How much you want to buy");
//int purchase = Convert.ToInt32(Console.ReadLine());


//// algrorith

//int[] change = { 20, 10, 5, 2, 1 };
//int result = Convert.ToInt32(inputMoney - purchase);
//int count;
//Console.WriteLine("The user entered $" + inputMoney + " and wants to buy a $" + purchase + "");

//for (int i = 0; i < change.Length; i++)
//{
//    count = result / change[i];
//    if (result != 0)
//    {
//        result %= change[i];
//        Console.WriteLine(change[i] + ": piece " + count);
//    }
//}
//Console.WriteLine("************************************");


//*****************************************************************************************************
// Question 2
//*****************************************************************************************************

// Compress


static string compress(string data)
{
    string answer = "";
    int counter = 1;
    for (int i = 0; i < data.Length; i++)
    {
        //algo if i = i+1 to keep track of counter
        if (i + 1 < data.Length && data[i] == data[i + 1])
        {
            counter++;
        }
    else
    {
        if (counter > 1)
        {
            answer += data[i] + counter.ToString();
            }
            else
            {
                answer+=data[i];
            }counter = 1;
    }
    }return answer;
}

Console.WriteLine("************************************");
Console.WriteLine("************************************");
Console.WriteLine("Here is your compress");
Console.WriteLine(compress("RTFFFFYYUPPPEEEUU"));


// decompress

static string decompress(string data)
{
    string answer = "";
    for (int i = 0; i < data.Length; i++)
    {   
        //algo if number is next char
        if (i + 1 < data.Length && char.IsDigit(data[i+1]))
        {
            int counter = int.Parse(data[i+1].ToString());
            for (int j = 0; j < counter; j++)
            {
                answer += data[i];
            }
            i++;
        }
        else
        {
            answer += data[i];
        }

    }
    return answer;
}

Console.WriteLine("************************************");
Console.WriteLine("************************************");
Console.WriteLine("Here is your decompress");
Console.WriteLine(decompress("RTF4YYUP3E3UU"));