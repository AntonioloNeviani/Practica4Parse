using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Archivo
    {
        private string @rutaDeArchivo;

        public List<string[]> getFileContent() 
        {
            List<string[]> csvArray = new List<string[]>();
            string line;
            string[] row;

            StreamReader readFile = new StreamReader(this.rutaDeArchivo);
            while ((line = readFile.ReadLine()) != null)
            {
                row = line.Split(',');
                csvArray.Add(row);
            }

            return csvArray;
        }

        public void verifyFileType()
        {

        	if(verifyPath()){
                if (Path.GetExtension(this.rutaDeArchivo) == ".csv")
                    Console.WriteLine("Tu archivo si es CSV");
                else
                    Console.WriteLine("Tu archivo no es CSV es " + Path.GetExtension(this.rutaDeArchivo) );
        	}else{
        		Console.WriteLine("Archivo no existe.");
        		System.Environment.Exit(0);
        	}
        }
        private Boolean verifyPath()
        {
            Boolean fileExist;
            if(File.Exists(this.rutaDeArchivo))
                fileExist = true;
            else
                fileExist = false;

            return fileExist;
        }
        public void leerArchivo()
        {
        try 
			{
            Console.WriteLine("Introduce la direccion y el nombre del Archivo a Leer:");
            this.rutaDeArchivo = Console.ReadLine();
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
        
    }
}
