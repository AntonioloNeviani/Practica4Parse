using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Archivo Archivo = new Archivo();
            Archivo.leerArchivo();
            Archivo.verifyFileType();
            List<string[]> myFile = Archivo.getFileContent();

            foreach(string[] array in myFile)
            {
			try 
				{
                Console.WriteLine("\nId: " + array[0] + "\nNombre: " + array[1] + 
				                  "\nDirección: " + array[2] + "\nTelefono: " + array[3]);
								}
				catch(Exception e)
				{
					Console.WriteLine("Exception: " + e.Message);
				}
			   	finally 
				{
					Console.WriteLine("Cerrando la lectura.");
				}
            }
            Console.ReadKey();
        }
    }
}
