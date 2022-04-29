// See https://aka.ms/new-console-template for more information

namespace FlippingCoin
{
    class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Let flip a coin 1000 times");
        Coinflip();
    }
    private static int Coinflip()
    {
        Random random = new Random();
        int heads = 0;
        int tails = 0;
        int result = 0;
        for (int i = 0; i<1000; i++)
        {
            result = random.Next(0, 2);
            if (result == 1)
            {
                heads++;
            }
            else
            {
                tails++;
            }

        }
        Console.WriteLine("heads was flipped {0} times", heads);
        Console.WriteLine("tails was flipped {0} times", tails);
        return result;
    }
}
}