using System;
class project
{
    public static void Main (string [] args)
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        string num3 = Console.ReadLine();

        int a = Convert.ToInt32(num1);
        int b = Convert.ToInt32(num2);
        int c = Convert.ToInt32(num3);

        if(a+b>c && a+c>b && b+c>a)
        {
            mohit (a,b,c);
        }
        else
        {
            Console.WriteLine("این یک مثلث نیست");
        }
    }

    private static void  mohit(int x, int y, int z)
    {
        int w = x+y+z;
        Console.WriteLine(w);
    }
}