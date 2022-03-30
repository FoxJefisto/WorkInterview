using FigureArea;
using FigureArea.Figures;
using System;

namespace WorkInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the figure class");
                if (!Figure.TryParse(Console.ReadLine(), out Figure figure))
                {
                    Console.WriteLine("Failed to create an instance for figure classes");
                    continue;
                }
                if (figure is Triangle && (figure as Triangle).IsRight())
                {
                        Console.WriteLine("This triangle is right");
                }
                Console.WriteLine("Enter the accuracy");
                Console.WriteLine(figure.Area(int.Parse(Console.ReadLine())));

                Console.WriteLine("Enter 'exit' to end the program");
                if (Console.ReadLine() == "exit")
                {
                    break;
                }
            }
        }
    }
}