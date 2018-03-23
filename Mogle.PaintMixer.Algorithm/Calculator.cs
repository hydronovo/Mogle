using System;
using System.Drawing;

namespace Mogle.PaintMixer.Algorithm
{
    public struct ColorRatio
    {
        public ColorRatio(Color color, double ratio)
        {
            Color = color;
            Ratio = ratio;
        }

        public Color Color { get; }
        public double Ratio { get; }
    }

    public class Calculator
    {
        public Color Mix(params ColorRatio[] colorRatios)
        {
            double r = 0;
            double g = 0;
            double b = 0;
            double ratioSum = 0;

            foreach (var cr in colorRatios)
            {
                if (cr.Ratio < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                r += cr.Color.R * cr.Ratio;
                g += cr.Color.G * cr.Ratio;
                b += cr.Color.B * cr.Ratio;
                ratioSum += cr.Ratio;
            }

            return Color.FromArgb(RgbValue(r, ratioSum), RgbValue(g, ratioSum), RgbValue(b, ratioSum));
        }

        private int RgbValue(double value, double ratioSum)
        {
            return (int)Math.Round(value / ratioSum);
        }

    }
}
