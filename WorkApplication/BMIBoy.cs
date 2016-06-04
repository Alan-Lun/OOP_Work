using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkApplication
{
    public class BMIBoy:IBMI
    {
        //private int Max { get; set; }
        //private int Min { get; set; }
       

        public int Max
        {
            get
            {
                return 25;
            }
        }

        public int Min
        {
            get
            {
                return 20;
            }

           
        }

       
    }
}
