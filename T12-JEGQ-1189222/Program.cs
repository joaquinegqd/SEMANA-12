using System;

namespace T12_JEGQ_1189222
{
    class Program
    {
        static int cantidadEquipos = 8;
        static Equipo[] equipos = new Equipo[cantidadEquipos];
        static Random random = new Random();

       

        static void mostrarEquipos()
        {
            int i = 0, j = cantidadEquipos - 1;
            while (i < cantidadEquipos / 2)
            {
                Console.WriteLine(equipos[i].nombre + "vs" + equipos[j].nombre);
                i++;
                j--;
            }
        }

        static void sortearEquipos()
        {
            for (int i = 0; i < cantidadEquipos; i++)
            {
                int x = random.Next(0, cantidadEquipos);
                Equipo aux = equipos[i];
                equipos[i] = equipos[x];
                equipos[x] = aux; 
            }
        }

        static int seleccionarGanador (int i, int j)
        {
            int x = random.Next(0, 100);
            if (x > 50)
            {
                return j;
            }
            return i;
        }

       static void simulacion()
        {
            while (cantidadEquipos > 1)
            {
                mostrarEquipos();
                Console.WriteLine("===================");
                int i = 0, j = cantidadEquipos - 1;

                while (i < cantidadEquipos / 2)
                {
                    Console.WriteLine(equipos[i].nombre + " vs " + equipos[j].nombre);
                    int x = seleccionarGanador(i, j);
                    Equipo aux = equipos[i];
                    equipos[i] = equipos[x];
                    equipos[x] = aux;

                    i++;
                    j--;
                    Console.WriteLine("Gano: " + equipos[i].nombre);
                    Console.WriteLine("---------------");
                }
                cantidadEquipos = cantidadEquipos / 2;
                Console.WriteLine("===============");
            }
            Console.WriteLine("El campeon es: " + equipos[0].nombre);
                
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < cantidadEquipos; i++)
            {
                equipos[i] = new Equipo();
                equipos[i].nombre = "Equipo" + i;
            }
            sortearEquipos();
            simulacion();
        }
    }
}
