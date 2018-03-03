using System;
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
            runProgram();
            computeInput();

        }
        public static void runProgram()
        {
            Console.WriteLine("Witaj ąęćóśł w programie obsługi wydatków, wybierz co chcesz zrobić?" );
            Console.WriteLine("1.Dodaj rachunek\n2.Wyswietl statystyke\n3.Zakoncz");

            try {
                UserChoice = int.Parse(Console.ReadLine());
            } catch ( ArgumentException E)
            {
                Console.WriteLine(E.Message);
                UserChoice = int.Parse(Console.ReadLine()) ;
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
                else if (value==3)
                {
                    Environment.Exit(2);
                }
                else
                {
                    throw new ArgumentException("Podaj wartosc 1, 2, lub 3");
                }
            }
        }
       
        private static void computeInput()
        {
            if (_choice == 1)
            {
                Expenses bill = new Expenses();
                Console.WriteLine("Dodawanie rachunku do bazy danych" );
                Console.Write("Podaj rachunek za Prad: ");
                bill.ElectricityRoomBill = Double.Parse(Console.ReadLine());
            }
            else
            {

            }
           

        }

    }


   
}
