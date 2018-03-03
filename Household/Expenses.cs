using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household
{
    internal class Expenses
    {
        private double _ElectricityRoomBill;
        public double ElectricityRoomBill
        {
            get { return _ElectricityRoomBill; }
            set
            {
                if(value > 0)
                {
                    _ElectricityRoomBill = value;
                }
                else
                {
                    throw new ArgumentException("Rachunek nie moze byc ujemny");
                }
            }
        }

        private double _HeatingBill;
        public double HeatingBill
        {
            get { return _HeatingBill; }
            set
            {
                if (value > 0)
                {
                    _HeatingBill = value;
                }
                else
                {
                    throw new ArgumentException("Rachunek nie moze byc ujemny");
                }
            }
        }

        private double _WarmWaterBill;
        public double WarmWaterBill
        {
            get { return _WarmWaterBill; }
            set
            {
                if (value > 0)
                {
                    _WarmWaterBill = value;
                }
                else
                {
                    throw new ArgumentException("Rachunek nie moze byc ujemny");
                }
            }
        }
        
        private double _ColdWaterBill;
        public double ColdWaterBill
        {
            get { return _ColdWaterBill; }
            set
            {
                if (value > 0)
                {
                    _ColdWaterBill = value;
                }
                else
                {
                    throw new ArgumentException("Rachunek nie moze byc ujemny");
                }
            }
        }

        private double _WasteBill;
        public double WasteBill
        {
            get { return _WasteBill; }
            set
            {
                if (value > 0)
                {
                    _WasteBill = value;
                }
                else
                {
                    throw new ArgumentException("Rachunek nie moze byc ujemny");
                }
            }
        }

        public double _ElectricitySharedBill;
        public double ElectricitySharedBill
        {
            get { return _ElectricitySharedBill; }
            set
            {
                if (value > 0)
                {
                    _ElectricitySharedBill = value;
                }
                else
                {
                    throw new ArgumentException("Rachunek nie moze byc ujemny");
                }
            }
        }


        public void ReadData()
        {
            Console.WriteLine("Dodawanie rachunku do bazy danych");

            Console.Write("Podaj rachunek za prąd: ");
            try { ElectricityRoomBill = Double.Parse(Console.ReadLine()); }
            catch (ArgumentException E ){
                Console.WriteLine(E.Message + " podaj nowy rachunek ");
                ElectricityRoomBill = Double.Parse(Console.ReadLine());
            }

            Console.Write("Podaj rachunek za ogrzewanie: ");
            try { HeatingBill = Double.Parse(Console.ReadLine());  }
            catch (ArgumentException E ){
                Console.WriteLine(E.Message + " podaj nowy rachunek ");
                HeatingBill = Double.Parse(Console.ReadLine());
            }

            Console.Write("Podaj rachunek za ciepłą wodę: ");
            try { WarmWaterBill = Double.Parse(Console.ReadLine());}
            catch (ArgumentException E ) {
                Console.WriteLine(E.Message + " podaj nowy rachunek ");
                WarmWaterBill = Double.Parse(Console.ReadLine());
            }

            Console.Write("Podaj rachunek za zimną wodę: ");
            try { ColdWaterBill = Double.Parse(Console.ReadLine()); }
            catch (ArgumentException E ) {
                Console.WriteLine(E.Message + " podaj nowy rachunek ");
                ColdWaterBill = Double.Parse(Console.ReadLine());
            }

            Console.Write("Podaj rachunek za śmieci: ");
            try { WasteBill = Double.Parse(Console.ReadLine()); }
            catch (ArgumentException E ){
                Console.WriteLine(E.Message + " podaj nowy rachunek ");
                WasteBill = Double.Parse(Console.ReadLine());
            }

            Console.Write("Podaj rachunek za prąd części wspólnej: ");
            try  { ElectricitySharedBill = Double.Parse(Console.ReadLine()); }
            catch (ArgumentException E) {
                Console.WriteLine(E.Message + " podaj nowy rachunek ");
                ElectricitySharedBill = Double.Parse(Console.ReadLine());
            }

        }
        public void WriteBills(TextWriter destination)
        {
            destination.WriteLine("Rachunek za prąd: " + ElectricityRoomBill);
            destination.WriteLine("Rachunek za ogrzewanie: " + HeatingBill);
            destination.WriteLine("Rachunek za ciepłą wodę: " + WarmWaterBill);
            destination.WriteLine("Rachunek za zimną wodę: " + ColdWaterBill);
            destination.WriteLine("Rachunek za śmieci: " + WasteBill);
            destination.WriteLine("Rachunek za prąd części wspólnej: " + ElectricitySharedBill);


        }


    }
}
