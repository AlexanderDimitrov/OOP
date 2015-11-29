using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Laptop.Model
{
    //Class Battery
    public class Battery
    {
        private BatteryType batteryType;
        private int cells;
        private int voltage;

        public Battery(BatteryType type, int cells, int voltage)
        {
            this.Cells = cells;
            this.Voltage = voltage;
            this.Type = batteryType;
        }
        //Type
        public BatteryType Type
        {
            get { return this.batteryType; }
            set
            {

                this.batteryType = value;
            }
        }
        //Cells
        public int Cells
        {
            get { return this.cells; }
            set
            {
                if (value < 0)
                {

                    throw new ArgumentException(string.Format(Constants.CantBeNegative, "Battery cells"));
                }
                this.cells = value;
            }
        }
        public int Voltage
        {
            get { return this.voltage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(Constants.CantBeNegative, "mAh"));
                }
                this.voltage = value;
            }


        }

        public override string ToString()
        {
            return $"{this.Type}, {this.Cells}-cells, {this.Voltage}";
        }


    }



}