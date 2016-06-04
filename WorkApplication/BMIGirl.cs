using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkApplication
{
    public class BMIGirl : IBMI
    {
        private decimal _Cm;
        public decimal Cm
        {
            get
            {
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
                    _Cm = value;
                }
            }
        }
        private decimal _Kg;
        public decimal Kg
        {
            get
            {
                return _Kg;
            }

            set
            {
                _Kg = value;
            }
        }

        public int Max
        {
            get
            {
                return 22;
            }
        }

        public int Min
        {
            get
            {
                return 18;
            }


        }

       
    }
}
