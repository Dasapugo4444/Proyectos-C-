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
    public class InmutableTest
    {
        [TestMethod]
        public void InmutableTestMethod()
        {
            String nombre = "MariANO";
            nombre = nombre.ToUpper();
            Assert.AreEqual("MARIANO", nombre);

            LibroValoraciones libro = new LibroValoraciones();
            libro.Nombre = "Mariano";
            libro.Nombre = libro.Nombre.ToUpper();
            Assert.AreEqual("MARIANO", libro.Nombre);

            DateTime fecha = new DateTime(1999,09,23);
            fecha = fecha.AddDays(1);
            Assert.AreEqual(24, fecha.Day);
        }
    }
}
