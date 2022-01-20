using System;

// Instresting that delegates type can be declared in Top-Level
public delegate double MyDelegate(double x);

class DelegateExample
{
    public static double Apply(double a, MyDelegate f)
    {
        return f(a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Anonymous function (lambda function) as delegate
        double res_lambda = DelegateExample.Apply(2, (a)=>a*2);
        Console.WriteLine(res_lambda);

        // Instant method as delegate 
        double resInstantMethod = DelegateExample.Apply(2, new Multiplier().InstantMethod);
        Console.WriteLine(resInstantMethod);

        //// Static method as delegate 
        double resStaticMethod = DelegateExample.Apply(2, Multiplier.StaticMethod);
        Console.WriteLine(resStaticMethod);
    }

}


class Multiplier
{
    public double InstantMethod(double x)
    {
        return x * x;
    }

    public static double StaticMethod(double x)
    {
        return x * x;
    }
}




