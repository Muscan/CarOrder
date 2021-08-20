using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrder
{
    class Engine
    {
      
        private string engineCombustion;
        public double enginePrice;

        public string EngineCombustion
        {
            get { return engineCombustion; }
            set { engineCombustion = value; }
        }

        public double EnginePrice
        {
            get { return enginePrice; }
            set { enginePrice = value; }
        }
    }
}
