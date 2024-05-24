using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeo
{
    internal class Cuadrado:Figura
    {
        public Cuadrado(float UnidadA)
        {
            Lado1 = UnidadA;
        }
        public override float area()
        {
            return Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return Lado1 + Lado1 + Lado1 + Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
