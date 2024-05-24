using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeo
{
    internal class Triangulo:Figura
    {

        private float lado2;
        
        public float Lado2
        {
            set
            {
                //pregunta si el lado <0
                if (value < 0)
                {
                    lado2 = 0; 
                }
                else
                {
                    lado2 = value;
                     
                }
            }
            get 
            {
                return lado2; 
            }
        }

        
        private float lado3;
        
        public float Lado3
        {
            set
            {
                
                if (value < 0)
                {
                    lado3 = 0; 
                }
                else
                {
                    lado3 = value;
                    
                }
            }
            get 
            {
                return lado3; 
            }
        }
        
        public Triangulo(float lado1, float lado2, float lado3)
        {
            
            this.Lado1 = lado1; 

            this.Lado2 = lado2;

            this.Lado3 = lado3;

        }

        
        public override float area()
        {
            return Lado1 * Lado2 / 2;
        }
        public override float perimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT 
        }
    }
}
