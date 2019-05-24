using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public enum IdiomaLibro
    {
        none, EN, ES, GE, IT
    }

    public class LibroValoraciones
    {
        private String _nombre;
        public String Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }
        }
        public IdiomaLibro Idioma;
        List<float> valoraciones;

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

        public CalcularValoraciones PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0;

            foreach(float valoracion in valoraciones)
            {
                calculo.ValMin = Math.Min(valoracion, calculo.ValMin);
                calculo.ValMax = Math.Max(valoracion, calculo.ValMax);
                sumaValoraciones += valoracion;
            }

            calculo.Prom = sumaValoraciones / valoraciones.Count;
            return calculo;
        }
    }
}
