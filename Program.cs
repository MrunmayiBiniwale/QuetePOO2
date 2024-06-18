using System.ComponentModel.DataAnnotations;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuetePOO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> listOfNumbers = new List<int>();
            int input = 0;
            int lengthOfList = 0;
            int whileCounter = 0;
            int n = 0;

            Console.WriteLine("How many numbers would you like to add in the list? ");
            int.TryParse(Console.ReadLine(), out lengthOfList);
            Console.WriteLine("Please enter numbers one per line :");

            while (whileCounter < lengthOfList) 
            {        
                int.TryParse(Console.ReadLine(), out input);
                listOfNumbers.Add(input);
                whileCounter++; 
            }

            Console.WriteLine("Please enter the limit number below which you would like to calculate the average : ");
            int.TryParse(Console.ReadLine(), out n);

            Program.DisplayArrayAndAverage(listOfNumbers, n);
        }

        public static void CalculateAverage(IList<int> listOfNumbers, int n, out double average, out IList<int> listLowerThanN)
        {
            listLowerThanN = new List<int>();
            listLowerThanN = listOfNumbers.Where(x => x <= n).ToList();
            average = listLowerThanN.Average();
        }

        public static void DisplayArrayAndAverage(IList<int> listOfNumbers, int n)
        {
            string printString = "[ ";
            double average = 0;
            IList<int> listLowerThanN;
            
            CalculateAverage(listOfNumbers, n, out average, out listLowerThanN);

            Console.WriteLine("\nThe Given Array : \n");

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (i == listOfNumbers.Count - 1)
                    printString += "" + listOfNumbers[i] + " ]";
                else
                    printString += "" + listOfNumbers[i] + ", ";
            }
            Console.WriteLine(printString);
            printString = "[ ";

            Console.WriteLine("\nThe Array considered for calculating average based on the limit : \n");

            for (int i = 0; i < listLowerThanN.Count; i++)
            {
                if (i == listLowerThanN.Count - 1)
                    printString += "" + listLowerThanN[i] + " ]";
                else
                    printString += "" + listLowerThanN[i] + ", ";
            }

            Console.WriteLine(printString);
            Console.WriteLine("\nAverage : " + average);                
        }
    }
}
