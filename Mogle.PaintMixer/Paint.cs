using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Mogle.PaintMixer
{
    public class Paint
    {
        public Paint(int id, Brand brand, string alias, string name, Glossiness glossiness, Color color)
        {
            Id = id;
            Brand = brand;
            Alias = alias;
            Name = name;
            Glossiness = glossiness;
            Color = color;
        }

        public int Id { get; }
        public Brand Brand {get;}
        public string Alias { get; }
        public string Name { get; }
        public Glossiness Glossiness { get; }
        public Color Color { get; }
    }
}
