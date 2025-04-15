// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Temperature Converter");

double Celdegree, fDegree;

Console.WriteLine("Enter the temperature:");

fDegree = Convert.ToDouble(Console.ReadLine());

Celdegree = 59 * (fDegree - 32);

Console.WriteLine(+fDegree + " F: is equivalent to:" + Celdegree + " C");

