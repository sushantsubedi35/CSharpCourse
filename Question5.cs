//Swap the values of two variables using a third variable.
using System;
class Question5
{
    public static void Main()
    {
        int a=2;
        int b=3;
        int c;
         c =b;
         b=a;
      a=c;
        Console.WriteLine($"the swap value of two variable {a} and {b}");
    }
}