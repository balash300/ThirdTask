﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class QuestionHandler
    {
        public static string ValidateYesNoInput(string str)
        {
            while (str != "y" && str != "n")
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.Write("Enter correct input: ");
                str = Console.ReadLine();
            }

            return str;
        }

        public static string ValidateNumericInput(string str)
        {
            while (str != "1" && str != "2" && str != "3")
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.Write("Enter correct input: ");
                str = Console.ReadLine();
            }

            return str;
        }

        public static string ValidateNumericInputForFont(string str)
        {
            while (str != "1" && str != "2")
            {
                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                Console.Write("Enter correct input: ");
                str = Console.ReadLine();
            }

            return str;
        }
    }
}
