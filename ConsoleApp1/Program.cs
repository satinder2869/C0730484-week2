sing System;

class Program
{
    static void Main(string[] args)
    {
        var red = new Blue("Roy", 17);
        // how to construct OBJECTS??? 
        // a constructor is a special method that constructs objects!!!! 
        Console.WriteLine(red.addNumbers());
        Console.ReadLine();
    }
}

class Blue
{
    public Blue()
    {
        Console.WriteLine("I am in the NO ARGUMENTS. ");
    }

    public Blue(string a, int b)
    {
        Console.WriteLine("{O} {1} ", a, b);
    }
    public int addNumbers()
    {
        int i;
        int sum = 0;
        for (i = 618; i >= 211; i -= 18)
        {
            sum += i;
        }
        return sum;
    }
}