using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public class Arrays
    {
        public void ArraysTrabados()
        {
            String[] arrayString;
            arrayString = new string[3];
            //String[] arrayString = new string {A,B,C};
            arrayString[0] = "A";
            arrayString[1] = "B";
            arrayString[2] = "C";

            String[] arrayString2 = arrayString;
            arrayString2[1] = "A";

            int[] numeros = { 1, 2, 3, 4, 5, 6, 8 };
            foreach (int numero in numeros)
            {
                Console.Write("{0}, ", numero);
            }
            Console.WriteLine();

            int[,] numeros2D = new int[3, 3] { { 3, 33, 3 }, { 5, 55, 5 }, { 3, 33, 3 } };
            foreach (int numero in numeros2D)
            {
                Console.Write("{0}, ", numero);
            }
            Console.WriteLine();

            int[,] numeros2D2 = { { 3, 33, 3 }, { 5, 55, 5 }, { 3, 33, 3 } };
            foreach (int numero in numeros2D2)
            {
                Console.Write("{0}, ", numero);
            }
            Console.WriteLine();
        }
    }
}
