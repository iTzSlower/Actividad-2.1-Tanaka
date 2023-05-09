using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2_1_Tanaka
{
    class Triangulo : Figura
    {
        float Base;
        float Altura;

        public Triangulo(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public virtual float Area()
        {
            return (Base * Altura)/2;
        }
    }
}
