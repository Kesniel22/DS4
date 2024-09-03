using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__3._3
{
    internal class CalculosMatematicos
    {
        public float calcularPerimetro(float alto, float ancho) 
        {
            float perimetro = 
                (float)alto*2 + (float)ancho*2;
            return perimetro;
        }
    }
}
