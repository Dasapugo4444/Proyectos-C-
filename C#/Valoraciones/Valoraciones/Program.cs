using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear libro
            LibroValoraciones libro = new LibroValoraciones();
            libro.Nombre = "aA";
            Console.WriteLine(libro.Nombre);
            libro.Idioma = IdiomaLibro.ES;
            Arrays miArray = new Arrays();
            //SpeechSynthesizer hablar = new SpeechSynthesizer();

            //Vetores
            Vector3D vector3D = new Vector3D();
            vector3D.x = 10;
            vector3D.y = 20;
            vector3D.z = 30.3f;

            //Asignar valoraciones
            libro.AgregarValoracion(3.5f);
            libro.AgregarValoracion(4);
            libro.AgregarValoracion(2.3f);
            libro.AgregarValoracion(4.2f);
            libro.AgregarValoracion(2);
            libro.AgregarValoracion(1.5f);

            //Arrays
            miArray.ArraysTrabados();

            //Publicar valoraciones
            CalcularValoraciones publicar = libro.PublicarValoraciones();

            //Promedio de valoraciones
            //hablar.Speak("Este es el promedio de las valoraciones:");
            float promedio = publicar.Prom;
            EscribirValoraciones("Promedio: ", promedio);

            //Valoración Máxima
            float valMax = publicar.ValMax;
            EscribirValoraciones("Valoracion máxima ", valMax);

            //Valoración Mínima
            float valMin = publicar.ValMin;
            EscribirValoraciones("Valoración mínima: ", (int)valMin);
        }

        private static void EscribirValoraciones(string descripcion, float valoracion)
        {
            Console.WriteLine("{0}"+"{1}", descripcion, valoracion);
        }

        private static void EscribirValoraciones(string descripcion, int valoracion)
        {
            Console.WriteLine("{0}" + "{1}", descripcion, valoracion);
        }
    }
}
