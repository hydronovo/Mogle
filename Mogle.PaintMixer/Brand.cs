using System;
using System.Collections.Generic;
using System.Text;

namespace Mogle.PaintMixer
{
    public class Brand
    {
        public Brand(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
