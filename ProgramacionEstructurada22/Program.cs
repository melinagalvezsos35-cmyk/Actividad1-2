using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
     static void Main(string[] args)
        {
            int cantidadPersonas;
            int edadPersona;
            string nombrePersona;

            Console.Write("Ingresa la cantidad de personas a clasificar: ");


            while (!int.TryParse(Console.ReadLine(), out cantidadPersonas)|| cantidadPersonas < 1)
            {
              Console.WriteLine("La cantidad debe ser numerico, no letras o simbolos");
              Console.Write("Ingresa la cantidad de personas a clasificar: ");
            }

            if (cantidadPersonas == 1)
            {
                Console.Write("Ingresa el nombre de la persona: "); 
                nombrePersona = Console.ReadLine();


                Console.Write("Ingresa la edad: ");
                while (!int.TryParse(Console.ReadLine(), out edadPersona))
                {
                    Console.WriteLine("La edad debe ser numerico, no letras o simbolos");
                    Console.Write("Ingresa la edad: ");
                }



                if (edadPersona >= 18)
                {
                    Console.WriteLine(nombrePersona +" Tiene "+ edadPersona+" años"+ "-"+" Es mayor de edad"); 
                }
                else
                {
                    Console.WriteLine(nombrePersona +" Tiene "+ edadPersona+" años"+ "-"+" Es menor de edad"); 
                }


            }
            else
            {
                List<string> nombreGeneral = new List<string>();
                List<int> edadGeneral = new List<int>();

                List<string> nombresPersonasMayores = new List<string>(); 
                List<int> edadesPersonasMayores = new List<int>();

                List<string> nombresPersonasMenores = new List<string>();
                List<int> edadesPersonasMenores = new List<int>();

                for (int i = 1; i <= cantidadPersonas; i++)
                {

                    Console.Write("Ingresa el nombre de la persona " + i + " = ");
                    nombrePersona = Console.ReadLine();
                    Console.Write("ingresa la edad " + i + " = ");
                    while (!int.TryParse(Console.ReadLine(), out edadPersona))
                    {
                        Console.WriteLine("La edad debe ser numérica, no simbolos o letra");
                        Console.Write("Ingresa la edad correcta: ");
                    }

                    nombreGeneral.Add(nombrePersona);
                    edadGeneral.Add(edadPersona);

                    if (edadPersona >= 18)
                    {
                        nombresPersonasMayores.Add(nombrePersona); 
                        edadesPersonasMayores.Add(edadPersona);
                    }
                    else
                    {
                        nombresPersonasMenores.Add(nombrePersona);
                        edadesPersonasMenores.Add(edadPersona);
                    }
                }

                Console.WriteLine("---- Lista GeneralL ----");
                Console.WriteLine(" ");
                for (int i = 0; i < nombreGeneral.Count; i++)
                {
                    Console.WriteLine(nombreGeneral[i] + " - " + edadGeneral[i] + " años");
                }

                if (nombresPersonasMayores.Count > 0)
                {

                   Console.WriteLine("----Personas Mayores----");
                   Console.WriteLine(" ");
                   for (int i = 0; i < nombresPersonasMayores.Count; i++) 
                   {
                    Console.WriteLine(nombresPersonasMayores[i] + " - " + edadesPersonasMayores[i]+ " años");
                   }
                }

                if (nombresPersonasMenores.Count > 0)
                {
                   Console.WriteLine("----PERSONAS MENORES----");
                   Console.WriteLine(" ");
                   for (int i = 0; i < nombresPersonasMenores.Count; i++)
                   {
                    Console.WriteLine(nombresPersonasMenores[i] + " - " + edadesPersonasMenores[i]+ " años");
                   }
                }
            }

        }
    }
