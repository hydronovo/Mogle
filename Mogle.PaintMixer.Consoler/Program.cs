using Mogle.PaintMixer.Algorithm;
using System;
using System.Drawing;

namespace Mogle.PaintMixer.Consoler
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine($"{Color.Green.R},{Color.Green.G},{Color.Green.B}");
            Console.WriteLine($"{Color.Red.R},{Color.Red.G},{Color.Red.B}");
            Console.WriteLine("");
            for (int i = 0; i < 100; i++)
            {
                var color = calculator.Mix(new ColorRatio(Color.Green, i), new ColorRatio(Color.Red, 100 - i));
                Console.WriteLine($"{color.R},{color.G},{color.B}");
            }
        }
    }
}
