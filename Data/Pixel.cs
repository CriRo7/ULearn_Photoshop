using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Data
{
    public class Pixel
    {
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
            if (val < 0 || val > 1)
                throw new ArgumentException();
            return val;
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
