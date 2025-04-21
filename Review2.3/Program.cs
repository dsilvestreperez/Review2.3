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

            Console.WriteLine("Enter the temperature:");

            fDegree = Convert.ToDouble(Console.ReadLine());//string varialbe for the fDegree

            Celdegree = 59 * (fDegree - 32);

            Console.WriteLine(+fDegree + " F: is equivalent to: " + Celdegree + " C");//Print output of the fDegree to Celderee
            }

    }

}

