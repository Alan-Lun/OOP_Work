using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkApplication
{
    public class BMICenter
    {
        public BMICenter(int intGender, decimal deccm, decimal deckg)
        {
            Gender = intGender;
            Cm = deccm;
            Kg = deckg;
        }
        private static int _Gender;

        public static int Gender
        {
            get { return _Gender; }
            set
            {
                if (value != 1 && value != 2)
                {
                    throw new Exception();
                }
                else
                {
                    _Gender = value;
                }

            }
        }


        private static decimal _Cm;
        public static decimal Cm
        {
            get
            {
                if (_Cm == 0)
                {
                    throw new Exception();
                }
                return _Cm;
            }

            set
            {
                if (value < 3)
                {
                    throw new Exception();
                }
                else
                {
                    _Cm = value / 100;
                }
            }
        }
        private static decimal _Kg;
        public static decimal Kg
        {
            get
            {
                if (_Kg == 0)
                {
                    throw new Exception();
                }
                return _Kg;
            }

            set
            {
                _Kg = value;
            }
        }

        private static IBMI _IBMI;
        private static decimal Result;

        public static int BMItest()
        {
            Result = Kg / (Cm * Cm);
            switch (Gender)
            {
                case 1:
                    {
                        _IBMI = new BMIBoy();
                        break;
                    }
                case 2:
                    {
                        _IBMI = new BMIGirl();
                        break;

                    }

            }
            return BMICenterReport(_IBMI.Max, _IBMI.Min, Result);




        }




        private static int BMICenterReport(int Max,int Min,decimal BMI)
        {
            if (BMI > Max)
            {
                return 1;
            }
            else if (BMI < Min)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
