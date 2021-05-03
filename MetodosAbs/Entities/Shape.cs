using System;
using System.Collections.Generic;
using System.Text;
using MetodosAbs.Entities.Enums;

namespace MetodosAbs.Entities
{
    // Classe abstract 
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }
        // Metodo abstract 
        public abstract double Area();

    }

}
