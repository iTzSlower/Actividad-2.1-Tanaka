using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad_2_1_Tanaka
{
    class Circulo : Figura
    {
        float Radio;

        public Circulo(float Radio)
        {
            this.Radio = Radio;
        }
        public virtual float Area()
        {
            return 3.14f * (Radio * Radio);
        }
    }
}
