using System;

namespace CorteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite cargar las listas agrupadas de las diferentes divisiones iferiors mixtas de un club,
            //con los datos solicitados de la edad, genero. Y cuantos viven a mas de 500km de la institucion.
            //Hacer un promedio general de edad y contar la cantidad de chicos por genero.
            int edad, division, divisionActual, genero, promedioF = 0, promedioM =0, distanciaKm, distanciaM =0, distanciaF = 0, con = 0, proEdad = 0;

            Console.WriteLine("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿A que division corresponde?: ");
            division = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el genero, 1 Para masculino y 2 Para femenino: ");
            genero = int.Parse(Console.ReadLine());
            Console.WriteLine("¿A que distancia vive de la Institucion?: ");
            distanciaKm = int.Parse(Console.ReadLine());
          

            while (edad > 0)
            {
                divisionActual = division;
                while (division == divisionActual)
                {
                    proEdad += edad;
                    if(genero == 1){
                        promedioM ++;
                        if(distanciaKm > 50)
                        distanciaM++;
                     }else
                        {
                            promedioF++;
                            if(distanciaKm > 50)
                            distanciaF++;
                        }
                            
                    {
                        con++;
                }

                    Console.WriteLine("Ingrese la edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el genero, 1 Para masculino y 2 Para femenino: ");
                    genero = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿A que division corresponde?: ");
                    division = int.Parse(Console.ReadLine());
                    Console.WriteLine("¿A que distancia vive de la Institucion?: ");
                    distanciaKm = int.Parse(Console.ReadLine());
                }
                    
            }
                proEdad = proEdad / con;
                distanciaKm = distanciaF + distanciaM;

                Console.WriteLine("El promedio general de edad es: " + proEdad);
                Console.WriteLine("La cantidad de chicos lejos del club son: " + distanciaKm);
                Console.WriteLine("La cantidad de chicos total es: " + con);
                Console.WriteLine("El promedio Masculino es: " + promedioM);
                Console.WriteLine("El promedio Femenino es: " + promedioF);
                Console.WriteLine("FIN DEL PROGRAMA..");
        }
    }
}
