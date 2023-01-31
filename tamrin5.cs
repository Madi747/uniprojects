using System;
class boolean
{
    public static void Main (string [] args)
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        int x = Convert.ToInt32(num1);
        int y = Convert.ToInt32(num2);
        float number1 = Math.Abs(x-y);
        double number2 = Math.Pow(number1 , Math.Abs(y));
        double number3 = Math.Sqrt(number2);
        Console.WriteLine(number3);

    }
}