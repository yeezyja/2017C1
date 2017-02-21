using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Youbmi
    {
        public double Tall { get; set; }
        public double wid { get; set; }

        public double GetBmi()
        {
           
            return wid / (Tall/100 * Tall/100);
        }

       
    }
}
