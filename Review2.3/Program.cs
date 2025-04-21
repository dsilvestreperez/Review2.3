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

            double Celdegree, fDegree;//input the celcius, and farhehaingt

            Console.WriteLine("Enter the temperature:");

            fDegree = Convert.ToDouble(Console.ReadLine());

            Celdegree = 59 * (fDegree - 32);//celcius equation

            Console.WriteLine(+fDegree + " F: is equivalent to: " + Celdegree + " C");//output
        }

    }

}

