using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangular : Tower
    {
        public override decimal Area()
        {
            return (this.Width * this.Height) / 2;
        }

        public override void PrintTower()

        {
            int height = 0;
            int temp = 0;
            int y = 0;
            int z = 0;
            int cnt = 0;
            Console.WriteLine("Scope: " + Scope());
            if (this.Width % 2 == 0 || this.Width / 2 > this.Height)
            {
                Console.WriteLine("Can not Print Area");
            }
            else if (this.Width % 2 > 0 && this.Width / 2 < this.Height)
            {
                height = this.Height - 2;
                temp = (this.Width - 2) / 2;
                y = height / temp;
                z = height - (y * temp);
                cnt = 0;
                for (int f = 0; f < this.Width / 2; f++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                Console.WriteLine("*");
                int cnt = 0;
                for (int i = 0; i < height; i++)
                {
                    cnt++;
                    for (int j = 3; j < this.Width - 1;)
                    {
                        if (i < z + y)
                            j = 3;
                        else
                            if (cnt % y == 0)
                            j += 2;
                    }
                    for (int s = 0; s < (this.Width - j) / 2; s++)
                    {
                        Console.Write(" ");
                    }
                    for (int star = 0; star < j; star++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    cnt = 0;
                }
              
                for (int i = 0; i < this.Width; i++)
                {
                    Console.Write("*");
                }

            }
            else Console.WriteLine("Area: " + Area());
            Thread.Sleep(1000);

        }

        public override decimal Scope()
        {
            return (this.Height * 2) + this.Width;
        }
    }
}
