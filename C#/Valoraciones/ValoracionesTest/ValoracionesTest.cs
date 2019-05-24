using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valoraciones;

namespace ValoracionesTest
{
    [TestClass]
    public class ValoracionesTest
    {
        [TestMethod]
        public void CalcularValoracionMax()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(2.3f);
            libro.AgregarValoracion(4.2f);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1.5f);
            CalcularValoraciones resultado = libro.PublicarValoraciones();
            Assert.AreEqual(4.2f, resultado.ValMax);
        }

        [TestMethod]
        public void CalcularValoracionMin()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(2.3f);
            libro.AgregarValoracion(4.2f);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1.5f);
            CalcularValoraciones resultado = libro.PublicarValoraciones();
            Assert.AreEqual(1.5, resultado.ValMin);
        }

        [TestMethod]
        public void CalcularValoracionPromedio()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(2.3f);
            libro.AgregarValoracion(4.2f);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1.5f);
            CalcularValoraciones resultado = libro.PublicarValoraciones();
            Assert.AreEqual(2.91, resultado.Prom, 0.01);
        }
    }
}
