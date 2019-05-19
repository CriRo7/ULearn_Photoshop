using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Data
{
    public class Pixel
    {
        const double ZERO = 0;
        const double ONE = 1;

        private double _r;
        public double R
        {
            get { return _r; }
            set
            {                
                _r = CheckValue(value);
            }   
        }
        private double _g;
        public double G
        {
            get { return _g; }
            set
            {

                _g = CheckValue(value);
            }
        }
        private double _b;
        public double B
        {
            get { return _b; }
            set
            {
                
                _b = CheckValue(value);
            }
        }

        public double CheckValue(double val)
        {
            if (val < ZERO || val > ONE)
                throw new ArgumentException();
            return val;
        }

        public static double Trim(double value)
        {
            if (value > ZERO)
                return ONE;
            if (value < ZERO)
                return ZERO;
            return value;
        }

        public double this[int index] {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.R;
                    case 1:
                        return this.G;
                    case 2:
                        return this.B;
                    default:
                        return 0;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.R = value;
                        break;
                    case 1:
                        this.G = value;
                        break;
                    case 2:
                        this.B = value;
                        break;
                    default:
                        break;
                }                   
            }
        }

    }
}
