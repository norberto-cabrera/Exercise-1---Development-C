using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Exercise_1___Development_C
{
    class Class1
        {
        public string StringComparison(string Str1, string Str2)
        {
            if (Str1 != null && Str2 != null)
            {
                if (Str1 == Str2)
                    return "Cadenas iguales\n";
                else
                    return "Cadenas differentes\n";

            }
            else
                return "Cadenas no validas\n";

        }

        public void VerifyBiggestNumber(int [] numbers)
        {
            Array.Sort(numbers);
            var size = numbers.Length;
            Console.WriteLine("El numero mas grande es: {0}\n", numbers[size-1]);

        }

        public void SortList(string [] strings)
        {
            Array.Sort(strings);
            Console.WriteLine("Arreglo Ascendente:");
            foreach (string  value in strings)
            {
                Console.Write(value + "\n");
            }
            Array.Reverse(strings);
            Console.WriteLine("\nArreglo Descendente:");
            foreach (string value in strings)
            {
                Console.Write(value + "\n");
            }
        }

        public int CountStringLength(string cadena)
        {
            char[] charArr = cadena.ToCharArray();
            int i = 0;
            foreach (char ch in charArr)
            {
                i++;
            }
            return i;
        }
        }

    class Class2
    {
        public void PrintFirstFiveValues(List<int> numbers)
        {
            List<int> secondnumbers = new List<int>();
            secondnumbers = numbers.GetRange(0,5);
            foreach (int number in secondnumbers)
            {
                Console.Write(number + "\n");
            }
        }

        public void PrintSmallestNumber(int [] numbers)
        {
            Array.Sort(numbers);
            Console.WriteLine("\nEl numero mas pequeño es: {0}", numbers[0]);
        }

        public void PrintDictionary()
        {
            var d = new Dictionary<string, int>();
            d.Add("One", 1);
            d.Add("Two", 2);
            d.Add("Three", 3);
            d.Add("Four", 4);
            d.Add("Five", 5);

            Console.WriteLine();
            foreach (string s in d.Keys)
                Console.WriteLine(s);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 object1 = new Class1();
            Class2 object2 = new Class2();

            Console.WriteLine("\nClass1");
            Console.WriteLine(object1.StringComparison("Cadena igual", "Cadena igual"));

            int[] numbers = new int[] { 1, 9, 200, 7, 5, 100 };
            object1.VerifyBiggestNumber(numbers);

            string[] strings = new string[] { "zanahoria", "tren", "casa", "cosa", "cosas" };
            object1.SortList(strings);

            string cadena = "Palomas";
            Console.WriteLine("\nLa cadena mide {0}",object1.CountStringLength(cadena));

            //Class 2
            Console.WriteLine("\nClass2");
            List<int> numeros = new List<int> { 1,2,3,4,5,6,7,8};
            object2.PrintFirstFiveValues(numeros);

            int[] smallest = new int[] { 1, 9, 200, 7, 5, 100, -3, 0, 4000 };
            object2.PrintSmallestNumber(smallest);

            object2.PrintDictionary();
        }
    }
}
