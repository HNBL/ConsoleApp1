using System;


public class Program
{

    static double Koren(double n)
    {
        double x = 1;
        double oldx;
        do
        {
            oldx = x;
            x = (x + n / x) / 2;
        }
        while (oldx != x);

        return x;
    }
    public static void Main()
    {
        double target = 2023;

        double x = Koren(target);

        Console.WriteLine(x);
        Console.WriteLine(x * x);

    }
}


//public class Program
//{
//    public static void Main()
//    {
//        double target = 2023;

//        double x = 1;
//        double oldx;
//        do
//        {
//            oldx = x;
//            x = (x + target / x) / 2;
//        }
//        while (oldx != x);
//        Console.WriteLine(x);
//        Console.WriteLine(x * x);

//    }
//}

