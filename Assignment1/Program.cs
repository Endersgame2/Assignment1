// Question 1 
// Here it will pompt the user for Input of his  total money
// Then it will make a simple subtraction from what he wants to buy by his input.
// algorithm works as: it has some special change values i.e 20,10 etc...
// it has a count which will divide the subtracted amount with the change where we run a loop of our values which fix we get that out.
// in loop we will simply check if its a non zero and then in condition we will simply match the modules from 20 and the result will be sent back again and then modules untill it becomes 0;
// if got time I will work on quantity of dollars.


//// Simple Prompt
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
    if (result != 0)
    {
        result %= change[i];
        Console.WriteLine(change[i] + ": piece " + count);
    }
}



//*****************************************************************************************************
// Question 2
//*****************************************************************************************************


// the major part to tackle in this question is maintaining cont and resting it back to 1 
// here this code is simply storing the count as current is the curren one which moves forward and compares the previous one if the count is more than 3 it will print
// if it founds an another char it will reset the count to 1 and if its only 1 it will just print it out.



// Please Uncomment the code there is a out of range Error


//using System.Text;

//Console.WriteLine("Please Enter a String in Upper Case");
//string str = Console.ReadLine();
//char[] input = str.ToCharArray(0, 0);
//StringBuilder sb = new StringBuilder();
//int count = 1;

//for (int i = 0; i < str.Length; i++)
//{
//    char current = input[0];
//    char previous = input[i-1];

//    if (current == previous)
//    {
//        count++;
//    }
//    else
//    {
//        if (count > 2)
//        {
//            sb.Append(count);
//            count = 1;
//        }
//        sb.Append(current);
//    }
//}