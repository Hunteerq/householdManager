using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household
{
    public class Expenses
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
            get { return WarmWaterBill; }
            set
            {
                if (value > 0)
                {
                    WarmWaterBill = value;
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

    }
}
