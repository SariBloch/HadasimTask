using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Tower
    {
        private decimal height;
        private decimal width;

        public decimal Height
        {
            get { return height; }
            set
            {
                if ((value >= 2))
                {
                    height = value;
                }
            }
        }

        public decimal Width
        {
            get { return width; }
            set { width = value; }
        }

        public Tower() { }

        public abstract void PrintTower();

        public abstract decimal Area();

        public abstract decimal Scope();

    }
}
