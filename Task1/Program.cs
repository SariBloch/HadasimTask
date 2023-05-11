// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;

namespace Task1
{
    class Program
    {
        public static List<Option> options;
        static void Main(string[] args)
        {
            // Create options that you want your menu to have
            options = new List<Option>
            {
                new Option("1. A Rectangular tower", () => AddTower(1)),
                new Option("2. Triangle tower", () => AddTower(2) ),
                new Option("3. Exit", () => Environment.Exit(0)),
            };

            // Set the default index of the selected item to be the first
            int index = 0;

            // Write the menu out
            WriteMenu(options, options[index]);

            // Store key info in here
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                // Handle each key input (down arrow will write the menu again with a different selected item)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < options.Count)
                    {
                        index++;
                        WriteMenu(options, options[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(options, options[index]);
                    }
                }
                // Handle different action for the option
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    options[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();

        }
        // Default action of all the options. You can create more methods
        public static void Clear()
        {
            Console.Clear();
            Thread.Sleep(1000);
            WriteMenu(options, options.First());
        }

        static void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(option.Name);
            }
        }

        static void AddTower(int type)
        {
            Console.WriteLine("Insert width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insert height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            Tower tower = null;

            if (type == 1)
                tower = new Rectangular() { Height = height, Width = width };

            if (type == 2)
                tower = new Triangular() { Height = height, Width = width };

            tower.PrintTower();
            Clear();
        }
    }

}