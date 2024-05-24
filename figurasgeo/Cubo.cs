using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeo
{
    internal class Cubo:Figura
    {
        public Cubo(float Medidas)
        {
            Lado1 = Medidas;
        }
        public override float area()
        {
            return (Lado1 * Lado1) * 6;
        }
        public override float perimetro()
        {
            return Lado1;
        }
        public override float volumen()
        {
            return (Lado1 * Lado1 * Lado1);
        }
    }
}
