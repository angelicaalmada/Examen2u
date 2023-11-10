using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2U
{
    public class Examen
    {
        public void Calificaciones()
        {
            int[] arreglo = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(0, 100);
            }
            Console.WriteLine("Muestra la lista desordenada");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            int temporal = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int x = i; x < arreglo.Length; x++)
                {
                    if (arreglo[i] > arreglo[x])
                    {
                        temporal = arreglo[i];
                        arreglo[i] = arreglo[x];
                        arreglo[x] = temporal;
                    }
                }
            }
            Console.WriteLine("muestrar lista ordenada");

            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }



        public void Curp()
        {
            char[] curp = new char[18];
            for (int i = 0; i < curp.Length; i++)
            {
                Console.WriteLine("Ingrese el valor: " + (i + 1));
                curp[i] = Convert.ToChar(Console.ReadLine());
            }
            if (curp.Length == 18)
            {
                string sexo = "";
                string fechaNacimiento = curp[4].ToString() + curp[5].ToString() + curp[6].ToString() + curp[7].ToString() + curp[8].ToString() + curp[9].ToString();

                if (curp[10] == 'H')
                {
                    sexo = "Masculinio";
                }
                else if (curp[10] == 'M')
                {
                    sexo = "Femenino";
                }
                Console.WriteLine($"La persona es del sexo {sexo} y su fecha de nacimiento es {fechaNacimiento}");
            }
            else
            {
                Console.WriteLine("curp no valida");
            }
        }



        public void vendedores()
        {
            int[,] arreglo = new int[6, 5] { { 500, 3000, 100,400,4000}, { 1000,150,200,500,1850}, {250,1800,2900,300,5250 },
        { 400,130,90,2400,3020}, {60,20,4000,3600,7680 }, { 2210,5100,7290,7200, 0} };

            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                if (i == 5)
                {
                    Console.Write("Total por vendedor:   ");
                }
                else
                {
                    Console.Write("producto " + (i + 1) + " \t" + "\t");
                }
                for (int x = 0; x < arreglo.GetLength(1); x++)
                {
                    Console.Write(arreglo[i, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("El vendedor 1 tuvo una ganancia de " + arreglo[5, 0]);
            Console.WriteLine("El vendedor 2 tuvo una ganancia de " + arreglo[5, 1]);
            Console.WriteLine("El vendedor 3 tuvo una ganancia de " + arreglo[5, 2]);
            Console.WriteLine("El vendedor 4 tuvo una ganancia de " + arreglo[5, 3]);

            Console.WriteLine($"El producto 1 genero {arreglo[0, 4]}");
            Console.WriteLine($"El producto 2 genero {arreglo[1, 4]}");
            Console.WriteLine($"El producto 3 genero {arreglo[2, 4]}");
            Console.WriteLine($"El producto 4 genero {arreglo[3, 4]}");
            Console.WriteLine($"El producto 5 genero {arreglo[4, 4]}");
        }
    }
}

