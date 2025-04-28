using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Consoledocumation
{
    internal class Program
    {
        static void Main(string[] args)
        {

               Console.WriteLine("Welcome to Temperature Converter");

            double Celdegree, fDegree;

            Console.WriteLine("Enter the temperature:");//puting the temperature of the weather

            fDegree = Convert.ToDouble(Console.ReadLine());//input the tempersture for the weather in Fahranhite

            Celdegree = 59 * (fDegree - 32);//the equation for changeing fahranhite to Celsius

            Console.WriteLine(+fDegree + " F: is equivalent to: " + Celdegree + " C");//Display the change from Fehranite to Celsius
            }

    }

}

