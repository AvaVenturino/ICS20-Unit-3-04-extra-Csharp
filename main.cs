// Created by: Ava Venturino
// Created on: April 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double fahrenheit;
        double celsius;
      
        //input
        Console.WriteLine("This program converts fahrenheit to celsius.");
        Console.WriteLine("");
        Console.WriteLine("Formula = C = (a°F - 32) x 5/9");
        Console.WriteLine("");
        Console.Write("Enter Fahrenheit : ");
        fahrenheit = Convert.ToInt32(Console.ReadLine());

        //process
        celsius = ((fahrenheit - 32) * 5.0 / 9.0);

        //output
        Console.WriteLine("");
        Console.Write("Volume of the sphere = " + celsius.ToString("0.00") + " °C");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}