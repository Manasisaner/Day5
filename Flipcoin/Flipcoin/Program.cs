// See https://aka.ms/new-console-template for more information

//namespace FlippingCoin
//{
//    class Program
//{
//    static void Main (string[] args)
//    {
//        Console.WriteLine("Let flip a coin 1000 times");
//        Coinflip();
//    }
//    private static int Coinflip()
//    {
//        Random random = new Random();
//        int heads = 0;
//        int tails = 0;
//        int result = 0;
//        for (int i = 0; i<1000; i++)
//        {
//            result = random.Next(0, 2);
//            if (result == 1)
//            {
//                heads++;
//            }
//            else
//            {
//                tails++;
//            }

//        }
//        Console.WriteLine("heads was flipped {0} times", heads);
//        Console.WriteLine("tails was flipped {0} times", tails);
//        return result;
//    }
//}
//}using System;  
//namespace CheckLeapYear
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Year : ");
//            int Year = int.Parse(Console.ReadLine());
//            if (Year % 4 == 0) 
//                Console.WriteLine("{0} is a Leap Year.", Year);
//            else Console.WriteLine("{0} is not a Leap Year.", Year);
//            Console.ReadLine();
//        }
//    }
//}
//calculate quetient and reminder//

//      namespace Quetient
//    { 
//        class Program
//        {
//          static void Main(string[] args)
//    {

//        int dividend = 50,divisor = 8;

//        int quotient = dividend / divisor;
//        int remainder = dividend % divisor;

//        Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
//        Console.WriteLine("Quotient = " + quotient);
//        Console.WriteLine("Remainder = " + remainder);
//        Console.ReadLine();
//    }
//}
//}

/*swap two numbers*/

// class SwapExample
//{
//    public static void Main(string[] args)
//    {
//        int a = 5, b = 10;
//        Console.WriteLine("Before swap a= " + a + " b= " + b);
//        a = a + b; //a=15 (5+10)      
//        b = a - b; //b=5 (15-10)      
//        a = a - b; //a=10 (15-5)   
//        Console.WriteLine("After swap a= " + a + " b= " + b);
//    }
//}

/*even odd no*/


//using System;

//namespace check1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            Console.Write("Enter a Number : ");
//            i = int.Parse(Console.ReadLine());
//            if (i % 2 == 0)
//            {
//                Console.Write("Entered Number is an Even Number");
//                Console.Read();
//            }
//            else
//            {
//                Console.Write("Entered Number is an Odd Number");
//                Console.Read();
//            }
//        }
//    }
//}

/*Check Whether an Alphabet is Vowel or Consonan*/

using System;
public class charpexercise
{
    static void Main(string[]args)
{
        char ch;
        Console.WriteLine("Enter any character: ");
        ch = Convert.ToChar(Console.ReadLine());
        // Condition for vowel checking
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {
            Console.WriteLine(ch + " is Vowel.");
        }
        else if((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
{
            Console.WriteLine(ch + " is Consonant.");
        }
        Console.ReadLine();
    }
}

