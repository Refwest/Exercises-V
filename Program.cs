using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesV;

class Program
{
    //// !Exercise 1 - Multiplication *2 and *10
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Enter your number");
    //    double number = double.Parse(Console.ReadLine());

    //    MultiplicationTable(number);

    //}
    //public static void MultiplicationTable(double number)
    //{
    //    double multiplication = 0;
    //    for (int i = 2; i <= 10; i++)
    //    {
    //        multiplication = number * i;
    //        Console.WriteLine("{0,2} * {1,2} = {2,2}",number, i, multiplication);
    //    }


    //}


    //// !Exercise 1 - Multiplication *2 and *10
    static void Main(string[] args)
    {
        Console.WriteLine("Write a number which will be squared and cubed");
        int number = int.Parse(Console.ReadLine());
        
        
        Console.WriteLine("Number {0} squared is {1}", number,  Square(number));
        Console.WriteLine("Number {0} cubedd is {1}", Cube(number));
    
    }

    public static int Square(int numbers)
    {
        int squareNumber = numbers * numbers;

        return squareNumber;
    }

    public static int Cube (int number)
    {
        int cubeNumber = Square(number) * number;
        
        return cubeNumber;
    }

}