using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioxResolverSP1_Aliaga
{
    public class Medico
    {
        public string NombreArchivo2 { get; set; }
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string EspecialidadId { get; set; }

        public bool GrabarMedico(Medico medico)
        {
            bool resultado = false;
            if (NombreArchivo2 != "")
            {
                // crea el stream en modo append
                StreamWriter sw = new StreamWriter(NombreArchivo2, true);
                // graba la linea con los valores de los campos
                sw.WriteLine(medico.Matricula.ToString() + "," +
                medico.Nombre + "," + medico.EspecialidadId);
                sw.Close(); // cerrar el stream
                sw.Dispose(); // liberar los recursos
                resultado = true;
            }
            return resultado;
        }
        public bool BuscarMatricula(string id)
        {
            // recibe el código del repuesto a buscar
            // devuelve falso si el código no existe en el archivo
            // devuelve verdadero si el código ya está grabado
            bool resultado = false;
            string Linea;
            string Matricula;
            // verificar que el archivo existe
            if (NombreArchivo2 != "" && File.Exists(NombreArchivo2))
            {
                // crear el stream en modo lectura
                StreamReader sr = new StreamReader(NombreArchivo2);
                // leer hasta el final
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine(); // lee una linea completa
                                           // el código está en el primer valor de cada línea
                    Matricula = Linea.Split(',')[0];
                    // comparar el código buscado con el del archivo
                    if (id == Matricula)
                    {
                        // si son iguales devuelve verdadero
                        resultado = true;
                        break; // sale del ciclo de lectura
                    }
                }
                sr.Close(); // cerrar el stream
                sr.Dispose(); // liberar los recursos
            }
            return resultado;
        }

    }

}
