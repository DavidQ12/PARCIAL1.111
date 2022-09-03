using System;
using System.Collections;

namespace PARCIAL1._111
{
    class Program
    {
        static void Main(string[] args)
        {
            int estudiantes;
            ArrayList registre = new ArrayList();
            String nombre;
            int edad;
            double nota1;
            double nota2;
            double nota3;
            double Promedio;
            int contador = 0;
            int fin;

            Console.WriteLine("Ingrese el numero de estudiantes a evaluar: ");
            estudiantes = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            while (contador < estudiantes)
            {
                Console.Write("==============Ingrese nombre del estudiante============= :");
                nombre = Console.ReadLine();
                Console.Write("===================Ingrese la edad del estudiante================= : ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("===================Ingrese la nota de Laboratorio 1================ : ");
                nota1 = int.Parse(Console.ReadLine());
                Console.Write("=======================Ingrese la nota de Laboratorio 2============== : ");
                nota2 = int.Parse(Console.ReadLine());
                Console.Write("===============Ingrese la nota de su parcial============== :");
                nota3 = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Promedio = ((nota1 * .3) + (nota2 * .3) + (nota3 * .4) / 3);
                Console.WriteLine("El promedio total del alumno es: {0}", Promedio);

                if (Promedio >= 6)
                {
                    Console.WriteLine("===========ALUMNO APROBADO========");

                }
                else
                {
                    Console.WriteLine("=========ALUMNO REPROBADO=========");
                }

                registre.Add(new estudiantes() { Nombre = nombre, Edad = edad, Nota1 = nota1, Nota2 = nota2, Nota3 = nota3, PromedioFinal = Promedio });

                contador++;
                Console.WriteLine(" ===== RESULTADOS ====== ");
                foreach (estudiantes st in registre)
                {
                    Console.WriteLine(st.getData());
                }
                {
                    Console.WriteLine("¿Quiere finalizar el proceso? Si desea finalizarla, presione 1");
                    fin = Convert.ToInt32(Console.ReadLine());
                }
                {
                    while (fin != 1) ;
                    Console.WriteLine("El proceso ha finalizado");
                }


            }
        }

        public class estudiantes
        {


            private string _nombre;
            private int _edad;
            private double _nota1;
            private double _nota2;
            private double _nota3;
            private double _Promedio;
            public string Nombre
            {

                get => _nombre;
                set => _nombre = value;

            }

            public int Edad
            {
                get => _edad;
                set => _edad = value;
            }

            public double Nota1
            {
                get => _nota1;
                set => _nota1 = value;
            }

            public double Nota2
            {
                get => _nota2;
                set => _nota2 = value;
            }
            public double Nota3
            {
                get => _nota3;
                set => _nota3 = value;





            }
            public double PromedioFinal
            {
                get => _Promedio;
                set => _Promedio = value;
            }
            public string getData()
            {
                return "Nombre: " + _nombre + " Edad: " + _edad + " Nota1:" + _nota1 + " Nota2: " + _nota2 + " Parcial: " + Nota3 + " Promedio: " + PromedioFinal;
            }
        }
    }
}

     
