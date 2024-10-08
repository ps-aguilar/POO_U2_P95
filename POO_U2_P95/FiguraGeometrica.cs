using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U2_P95
{
    internal abstract class FiguraGeometrica
    {
        private string nombre;

        public FiguraGeometrica(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract float CalcularArea();
        public abstract float CalcularPerimetro();
    }
}
