using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UpMyKnowlege
{
    class Format : IFormattable
    {
        private int number;

        public Format()
        {
            
        }

        public Format(int a)
        {
            number = a;
        }


        public override string ToString()
        {
            return this.ToString("G", CultureInfo.CurrentCulture);
        }

       /* public string ToString(string format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }*/

        public string ToString(string format, IFormatProvider formatProvider)
        {
            string temp = number.ToString();
            switch (format)
            {
                case "D":
                    temp = (number * 2).ToString();
                    break;
                case "Q":
                    temp = (number * 4).ToString();
                    break;
                case "M3":
                    temp = (number * 3).ToString();
                    break;
                default:
                    break;
            }
            return temp;
        }
    }
}
