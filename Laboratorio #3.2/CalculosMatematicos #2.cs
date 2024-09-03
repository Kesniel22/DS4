using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__3._2
{
    internal class CalculosMatematicos
    {
        public float calculoArea(float r)
        {
            float area;
            float PI = (float)Math.PI;
            area = PI * r * r;
            return area;
        }
    }
}
