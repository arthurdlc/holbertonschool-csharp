using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);

        switch (number)
        {
            case < 0:
                Console.WriteLine("{0} is negative", number);
                break;
            case > 0:
                Console.WriteLine("{0} is positive", number);
                break;
            default:
                Console.WriteLine("{0} is zero", number);
                break;
        }
    }
}
