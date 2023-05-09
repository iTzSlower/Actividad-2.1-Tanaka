using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2_1_Tanaka
{
    class Cuadrado : Figura
    {
        float Lado;

        public Cuadrado(float Lado)
        {
            this.Lado = Lado;
        }
        public virtual float Area()
        {
            return Lado * Lado;
        }
    }
}
