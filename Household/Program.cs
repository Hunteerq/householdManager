using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household
{
    class Program
    {
        static void Main(string[] args)
        {
            Expenses Bill = new Expenses();
            runProgram();
            computeInput(Bill);

        }

        public static void runProgram()
        {
            Console.WriteLine("Witaj  w programie obsługi wydatków, wybierz co chcesz zrobić?" );
            Console.WriteLine("1.Dodaj rachunek\n2.Wyswietl statystyke\n3.Zakoncz");

            try {
                UserChoice = int.Parse(Console.ReadLine());
            } catch ( ArgumentException E)
            {
                Console.WriteLine(E.Message);
                UserChoice = int.Parse(Console.ReadLine()) ;
            }
        }
        private static void computeInput(Expenses Bill)
        {
            if ( UserChoice == 1)
            {
                readingDataAndValidation(Bill);
                saveDataToFile(Bill);

            }
            else
            {
                /* TODO */
            }
           

        }

      

        private static void readingDataAndValidation(Expenses Bill)
        {
            string validation = "n";
            do
            {
                collectingData(Bill);
                validation = Console.ReadLine();
            }
            while (validation != "y" && validation != "Y");
        }

        private static void collectingData(Expenses Bill)
        {
            Bill.ReadData();
            Console.WriteLine("Dziękuję za wprowadzenie danych, twoje dane to: \n");
            Console.WriteLine("--------------------------------------------------");
            Bill.WriteBills(Console.Out);
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Potwierdz, czy rachunki się zgadzają [y/n]:");
        }

        private static void saveDataToFile(Expenses Bill)
        {
            using (StreamWriter outputFile = File.AppendText("data.txt"))
            {
                Bill.WriteBills(outputFile);
            }

        }
        private static int _choice;
        private static int UserChoice
        {
            get { return _choice; }
            set
            {
                if (value == 1 || value == 2)
                {
                    _choice = value;
                }
                else if (value == 3)
                {
                    Environment.Exit(2);
                }
                else
                {
                    throw new ArgumentException("Podaj wartosc 1, 2, lub 3");
                }
            }
        }

    }



}
