using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        int cantidadPersonas = LeerEntero("Ingresa la cantidad de personas a clasificar: ");

        if (cantidadPersonas == 1)
        {
            Console.Write("Ingresa el nombre de la persona: ");
            string nombrePersona = Console.ReadLine();

           
            int edadPersona = LeerEntero("Ingresa la edad: ");

            if (EsMayor(edadPersona))
            {
                Console.WriteLine($"{nombrePersona} Tiene {edadPersona} años - Es mayor de edad");
            }
            else
            {
                Console.WriteLine($"{nombrePersona} Tiene {edadPersona} años - Es menor de edad");
            }
        }
        else
        {
            List<string> nombreGeneral = new List<string>();
            List<int> edadGeneral = new List<int>();
            List<string> nombresMayores = new List<string>();
            List<int> edadesMayores = new List<int>();
            List<string> nombresMenores = new List<string>();
            List<int> edadesMenores = new List<int>();

            for (int i = 1; i <= cantidadPersonas; i++)
            {
                Console.Write($"Ingresa el nombre de la persona {i} = ");
                string nombre = Console.ReadLine();
                int edad = LeerEntero($"Ingresa la edad {i} = ");

                nombreGeneral.Add(nombre);
                edadGeneral.Add(edad);

                
                if (EsMayor(edad))
                {
                    nombresMayores.Add(nombre);
                    edadesMayores.Add(edad);
                }
                else
                {
                    nombresMenores.Add(nombre);
                    edadesMenores.Add(edad);
                }
            }

            
            ImprimirListas(nombreGeneral, edadGeneral, nombresMayores, edadesMayores, nombresMenores, edadesMenores);
        }
    }

    

    
    static int LeerEntero(string mensaje)
    {
        int valor;
        Console.Write(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor) || valor < 1)
        {
            Console.WriteLine("La edad debe ser numérica, no símbolos o letra");
            Console.Write("Intente de nuevo: ");
        }
        return valor;
    }

       static bool EsMayor(int edad)
    {
        return edad >= 18;
    }

    
    static void ImprimirListas(List<string> genNom, List<int> genEd, List<string> mayNom, List<int> mayEd, List<string> menNom, List<int> menEd)
    {
        Console.WriteLine("\n---- Lista General ----");
        for (int i = 0; i < genNom.Count; i++)
        {
            Console.WriteLine($"{genNom[i]} - {genEd[i]} años");
        }

        if (mayNom.Count > 0)
        {
            Console.WriteLine("\n---- Personas Mayores ----");
            for (int i = 0; i < mayNom.Count; i++)
            {
                Console.WriteLine($"{mayNom[i]} - {mayEd[i]} años");
            }
        }

        if (menNom.Count > 0)
        {
            Console.WriteLine("\n---- PERSONAS MENORES ----");
            for (int i = 0; i < menNom.Count; i++)
            {
                Console.WriteLine($"{menNom[i]} - {menEd[i]} años");
            }
        }
    }
}
