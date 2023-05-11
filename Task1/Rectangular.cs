using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Rectangular : Tower
    {
        public override decimal Area()
        {
            return this.Width * this.Height;
        }

        public override void PrintTower()
        {
            if (this.Height - this.Width > 5)
            {
                Console.WriteLine("Scope: " + Scope());
            }
            else
            {
                Console.WriteLine("Area: " + Area());
            }
            Thread.Sleep(1000);
        }

        public override decimal Scope()
        {
            return (this.Width + this.Height) * 2;
        }
    }
}
