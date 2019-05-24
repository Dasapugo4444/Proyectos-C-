using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valoraciones;

namespace ValoracionesTest.Tipos
{
    [TestClass]
    public class TiposValorTests
    {
        /*
        int x;
        float y;
        double z;
        string cadenas;
        */

        [TestMethod]
        public void TiposValorTest()
        {
            int x1 = 10;
            int x2 = x1;
            Assert.AreEqual(x1, x2);
        }

        [TestMethod]
        public void EnumTest()
        {
            LibroValoraciones libro = new LibroValoraciones();
            libro.Idioma = IdiomaLibro.ES;
            Assert.AreEqual(libro.Idioma, IdiomaLibro.ES);
        }
    }
}
