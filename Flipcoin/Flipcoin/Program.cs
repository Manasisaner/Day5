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

 class SwapExample
{
    public static void Main(string[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a + b; //a=15 (5+10)      
        b = a - b; //b=5 (15-10)      
        a = a - b; //a=10 (15-5)   
        Console.WriteLine("After swap a= " + a + " b= " + b);
    }
}
