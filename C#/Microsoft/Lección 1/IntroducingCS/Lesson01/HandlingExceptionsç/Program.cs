using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptionsç
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void ExceptionTest()
        {
            StreamReader sr = null;

            try

            {

                sr = File.OpenText(@"c:\datsasdaasda.txt");

                Console.WriteLine(sr.ReadToEnd());

            }

            catch (FileNotFoundException fnfe)

            {

                Console.WriteLine(fnfe.Message);

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }
        }
    }
}
