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
    public class TiposReferencia
    {
        [TestMethod]
        public void VariablesTipoReferencia()
        {
            LibroValoraciones l1 = new LibroValoraciones();
            l1.Nombre = "Su cucha";
            LibroValoraciones l2 = l1;
            l1.Nombre = "Su cucho";
            Assert.AreEqual(l1.Nombre, l2.Nombre);
        }

        [TestMethod]
        public void ArraysTest()
        {
            letras = new string[3];
            AgregarLetra("A");
            Assert.AreEqual("A", letras[0]);
        }

        [TestMethod]
        public void NumerosArraysTest()
        {
            numeros = new int[3];
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            int[] numeros2 = numeros;

            Assert.AreEqual(numeros2[0], numeros[0]);
        }

        private void AgregarLetra(string l)
        {
            letras[0] = l;
        }

        String[] letras;
        int[] numeros;
    }
}
