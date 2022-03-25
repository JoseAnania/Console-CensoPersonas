using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CensoPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni, sexo, edad;
            int contadorPersonas = 0, contadorM=0, contadorF=0, contadorEdad=0;
            int porcentaje = 0;
            
            Console.WriteLine("Ingresar DNI: ");
            dni = Convert.ToInt32(Console.ReadLine());
           
            while(dni!=0)
            {
                contadorPersonas++;

                Console.WriteLine("Seleccione Sexo: | 1-Masculino | 2-Femenino |");
                sexo = Convert.ToInt32(Console.ReadLine());

                if(sexo==1)
                {
                    contadorM++;
                }
                else
                {
                    contadorF++;
                }

                Console.WriteLine("Ingrese Edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                if(edad>16 && edad<65 && sexo==1)
                {
                    contadorEdad++;
                }

                porcentaje = (contadorEdad *100 / contadorM);

                Console.WriteLine("Ingresar DNI: ");
                dni = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Cantidad de Personas censadas: " + contadorPersonas);
            Console.WriteLine("Cantidad de Varones: " + contadorM);
            Console.WriteLine("Cantidad de Mujeres: " + contadorF);
            Console.WriteLine("Porcentaje de Hombres entre 16 y 65 años: " + porcentaje + "%");
            Console.Read();
        }
    }
}
