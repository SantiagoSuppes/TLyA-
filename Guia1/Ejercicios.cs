using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    internal class Ejercicios
    {
        //Ejercicios asignados en la clase virtual del 17/03: Ej1 - Ej8.
        public void Ej1()
        {
            Console.WriteLine("Hola Mundo");
        }

        public void Ej2()
        {
            string nombreUsuario;
            byte edadUsuario;
            string paisUsuario;

            Console.Write("Digame su nombre: ");
            nombreUsuario = Console.ReadLine();

            Console.Write("Digame su edad: ");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            Console.Write("Digame su pais: ");
            paisUsuario = Console.ReadLine();

            Console.WriteLine("Su nombre es " + nombreUsuario + ", su edad es " + edadUsuario + " y su pais es "
                + paisUsuario + ".");
        }

        public void Ej3()
        {
            Console.Write("Digame su nombre: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Digame su apellido: ");
            string apellidoUsuario = Console.ReadLine();

            Console.Write("Digame su edad: ");
            string edadUsuario = Console.ReadLine();

            Console.Write("Digame su carrera: ");
            string carreraUsuario = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Su nombre es " + nombreUsuario + ", su apellido es " + apellidoUsuario +
                ", su edad es " + edadUsuario + " y estudia " + carreraUsuario + ".");
            Console.WriteLine();
            Console.WriteLine("Su nombre es " + nombreUsuario);
            Console.WriteLine("Su apellido es " + apellidoUsuario);
            Console.WriteLine("Su edad es " + edadUsuario);
            Console.WriteLine("Su carrera es " + carreraUsuario);
        }

        public void Ej4a()
        {
            Console.Write("Cuantas materias tiene su carrera? ");
            byte materiasCarrera = Convert.ToByte(Console.ReadLine());

            Console.Write("Y cuantas materias tiene aprobadas? ");
            byte materiasAprobadas = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("A usted le faltan " + (materiasCarrera - materiasAprobadas) + " materias para recibirse.");
        }
        public void Ej4b()
        {
            const byte materiasCarrera = 32;

            Console.Write("Cuantas materias tiene aprobadas? ");
            byte materiasAprobadas = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("A usted le faltan " + (materiasCarrera - materiasAprobadas) + " materias para recibirse.");
        }

        public void Ej5()
        {
            Console.Write("Ingrese el primer numero: ");
            byte primerNum = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            byte segundoNum = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");
            byte tercerNum = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese el cuarto numero: ");
            byte cuartoNum = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("El orden inverso al ingresado es: " + cuartoNum + "," + tercerNum + 
                "," + segundoNum + "," + primerNum);
        }

        public void Ej6()
        {
            Console.Write("Ingrese la altura del triangulo: ");
            byte alturaTriangulo = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese la base del triangulo: ");
            byte baseTriangulo = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("El area del triangulo es " + (alturaTriangulo * baseTriangulo)/2 + " cm^2");
        }

        public void Ej7()
        {
            Console.Write("Ingrese la altura del rectangulo: ");
            byte alturaRectangulo = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese la base del rectangulo: ");
            byte baseRectangulo = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("El area del rectangulo es " + (alturaRectangulo * baseRectangulo) +
                " cm^2, y su perimetro es " + (alturaRectangulo*2 + baseRectangulo*2)+ " cm^2.");
        }

        public void Ej8()
        {
            Console.Write("Ingrese la nota del primer parcial teorico: ");
            byte primerParcialTeorico = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese la nota del segundo parcial teorico: ");
            byte segundoParcialTeorico = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese la nota del primer parcial practico: ");
            byte primerParcialPractico = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese la nota del segundo parcial practico: ");
            byte segundoParcialPractico = Convert.ToByte(Console.ReadLine());

            int promedioTeorico = (primerParcialTeorico + segundoParcialTeorico) / 2;
            int promedioPractico = (primerParcialPractico + segundoParcialPractico) / 2;

            Console.WriteLine("Su promedio teorico es " + promedioTeorico + ", su promedio practico es " 
                + promedioPractico + ", con lo que su promedio total es " + (promedioTeorico + promedioPractico)/2);
        }

        public void Ej9()
        {
            int acumulador = 0;

            Console.Write("Ingrese el primer numero: ");
            acumulador += Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            acumulador += Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            acumulador += Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el cuarto numero: ");
            acumulador += Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es: " + acumulador);
        }


        public void Ej10()
        {
            int cantMateriasAprobadas;
            int cantMateriasRendidas;
            float promedio;
            float ranking;

            Console.Write("Cuantas materias tiene aprobadas? ");
            cantMateriasAprobadas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cuantas materias rindio? ");
            cantMateriasRendidas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su promedio: ");
            promedio = Convert.ToSingle(Console.ReadLine());

            ranking = (cantMateriasAprobadas/cantMateriasRendidas)*100 + cantMateriasAprobadas*3 + promedio*3;
            Console.WriteLine("Su ranking es: " + ranking);
        }


        public void Ej11()
        {
            float precio1 = 250.00f;
            float precio2 = 100.50f;
            float precio3 = 85.20f;

            Console.Write("Cuantas unidades compro del primer producto? ");
            int UdeP1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cuantas unidades compro del segundo producto? ");
            int UdeP2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cuantas unidades compro del tercer producto? ");
            int UdeP3 = Convert.ToInt32(Console.ReadLine());

            float monto = (precio1 * UdeP1) + (precio2 * UdeP2) + (precio3 * UdeP3);
            Console.Write("Usted debe abonar un total de " + monto);
        }
    }   
} 
