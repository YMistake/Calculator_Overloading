using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class Calculator
{
    public static int add(int a, int b)
    {
        return a + b;
    }
    public static float add(float a, float b)
    {
        return a + b;
    }
    public static int sub(int a, int b)
    {
        return a - b;
    }
    public static float sub(float a, float b)
    {
        return a - b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("2 + 5 = " + Calculator.add(2, 5));
        Console.WriteLine("2.5 + 5.5 = " + Calculator.add(2.5f, 5.5f));
        Console.WriteLine("5 - 2 = " + Calculator.sub(5, 2));
        Console.WriteLine("5.2 - 2.5 = " + Calculator.sub(5.2f, 2.5f));
    }

}


