using System;
using TriangleTracker;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number for side 1: ");
        int side1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for side 2: ");
        int side2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number for side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if (Triangle.isNotTriangle(side1, side2, side3))
        {
            Console.WriteLine("Epic Fail. This is not a triangle.");
        }
        else if (Triangle.isEqualTriangle(side1, side2, side3))
        {
            Console.WriteLine("Equilateral Triangle");
        }
        else if (Triangle.isIsoTriangle(side1, side2, side3))
        {
            Console.WriteLine("Isosceles Triangle");
        }
        else if (Triangle.isScalTriangle(side1, side2, side3))
        {
            Console.WriteLine("Scalene Triangle");
        }
        else
        {
            Console.WriteLine("FAIL");
        }
        Main();

    }
}