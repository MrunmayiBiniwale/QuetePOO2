using System.ComponentModel.DataAnnotations;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuetePOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = new List<int>();
            int input = 0;
            int lengthOfList = 0;
            int whileCounter = 0;

            Console.WriteLine("How many numbers would you like to add in the list? ");
            int.TryParse(Console.ReadLine(), out lengthOfList);
            Console.WriteLine("Please enter numbers one per line :");

            while (whileCounter < lengthOfList) 
            {        
                int.TryParse(Console.ReadLine(), out input);
                listOfNumbers.Add(input);
                whileCounter++; 
            }

            Program.DisplayArrayAndAverage(listOfNumbers);
        }

        public static double CalculateAverage(List<int> listOfNumbers)
        {
            double average = listOfNumbers.Average();
            return average;
        }

        public static void DisplayArrayAndAverage(List<int> listOfNumbers)
        {
            string printString = "[ ";

            double  average = CalculateAverage(listOfNumbers);

            Console.WriteLine("\nThe Given Array : \n");

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (i == listOfNumbers.Count - 1)
                    printString += "" + listOfNumbers[i] + " ]";
                else
                    printString += "" + listOfNumbers[i] + ", ";
            }

            Console.WriteLine(printString);
            Console.WriteLine("\nAverage : " + average);                
        }
    }
}
