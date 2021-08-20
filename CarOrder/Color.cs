using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrder
{
    class Color
    {
        private string colorName;
        private double colorPrice;

        public string ColorName
        {
            get { return colorName; }
            set { colorName = value; }
        }

        public double ColorPrice
        {
            get { return colorPrice; }
            set { colorPrice = value; }
        }
    }
}
