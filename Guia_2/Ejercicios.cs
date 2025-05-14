using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guia_2
{
    internal class Ejercicios
    {
        public void Ej1()
        {
            int numero;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine($"El numero ingresado es mayor a 0.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El numero ingresado es menor a 0.");
            }
            else
            {
                Console.WriteLine($"El numero ingresado es igual a 0.");
            }

            Console.WriteLine(numero);
        }

        public void Ej2()
        {
            int monto;
            int total = 0;
            string respuesta;

            do
            {
                Console.Write("Ingrese un monto: ");
                monto = Convert.ToInt32(Console.ReadLine());

                total += monto;

                Console.Write("Desea ingresar otro monto? (s/n): ");
                respuesta = Console.ReadLine().ToLower();


            } while (respuesta == "s");

            Console.WriteLine($"El monto total es: {total}.");
        }

        public void Ej4()
        {
            int colectivo = 30;
            int subte = 15;
            int bicicleta = 45;

            Console.WriteLine("Los tiempos de viaje son los siguientes:" + "\n"
                + $"Colectivo: {colectivo} min" + "\n"
                + $"Subte: {subte} min" + "\n"
                + $"Bicicleta: {bicicleta} min");

            bool flag = false;
            string respuesta;
            do
            {
                Console.Write("Cual desea tomar? (C/S/B): ");
                respuesta = Console.ReadLine().ToUpper();

                if (respuesta == "C" || respuesta == "S" || respuesta == "B")
                {
                    flag = true;
                    if (respuesta == "C")
                    {
                        Console.WriteLine($"Usted eligió colectivo y tardará {colectivo} minutos.");
                    }
                    else if (respuesta == "S")
                    {
                        Console.WriteLine($"Usted eligió subterraneo y tardará {subte} minutos.");
                    }
                    else
                    {
                        Console.WriteLine($"Usted eligió bicicleta y tardará {bicicleta} minutos.");
                    }
                }
                else
                {
                    Console.Write("Opcion invalida. Ingrese el transporte que desea tomar.");
                }
            } while (!flag);
        }

        public void Ej5()
        {
            Console.WriteLine( 
                "1. Altas" + "\n" +
                "2. Bajas" + "\n" +
                "3. Modificaciones" + "\n" +
                "4. Salir");

            bool flag = false;
            byte respuesta;

            // Utilizando if
            do
            {
                Console.Write("Seleccione una opcion: ");
                respuesta = Convert.ToByte(Console.ReadLine());

                if (respuesta == 1 || respuesta == 2 || respuesta == 3 || respuesta == 4)
                {
                    flag = true;
                    if (respuesta == 1)
                    { Console.WriteLine("Usted eligio Altas."); }
                    else if (respuesta == 2)
                    { Console.WriteLine("Usted eligio Bajas."); }
                    else if (respuesta == 3)
                    { Console.WriteLine("Usted eligio Modificaciones."); }
                    else { Console.WriteLine("Saliendo"); }
                }
                else
                {
                    Console.WriteLine("Dato erróneo.");
                }
            } while (!flag);

            // Utilizando switch

            Console.Write("Seleccione una opcion: ");
            respuesta = Convert.ToByte(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Usted eligio Altas.");
                    break;
                case 2:
                    Console.WriteLine("Usted eligio Bajas.");
                    break;
                case 3:
                    Console.WriteLine("Usted eligio Modificaciones.");
                    break;
                case 4:
                    Console.WriteLine("Saliendo");
                    break;
                default:
                    Console.WriteLine("Dato erroneo");
                    break;
            }
        }

        public void Ej6()
        {
            Console.Write("Ingrese un numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ahora ingrese otro numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 != num2)
            {
                Console.WriteLine("Los numeros ingresados son distintos.");
            }
            else { Console.WriteLine("Los nuemros ingresados son iguales."); }
        }

        public void Ej7()
        {
            int lado1 = 0;
            int lado2 = 0;
            int lado3 = 0;
            bool flag = false;

            Console.WriteLine("Se le pediran las medidas de los tres lados de un triangulo.");
            do
            {
                do
                {
                    Console.Write("Ingrese la medida del primer lado: ");
                    lado1 = Convert.ToInt32(Console.ReadLine());

                    if (lado1 <= 0)
                    {
                        Console.WriteLine("La medida debe ser positiva.");
                    } 
                    else
                    {
                        flag = true;
                    }
                } while (lado1 <= 0);

                do
                {
                    Console.Write("Ingrese la medida del segundo lado: ");
                    lado2 = Convert.ToInt32(Console.ReadLine());

                    if (lado2 <= 0)
                    {
                        Console.WriteLine("La medida debe ser positiva.");
                    }
                    else
                    {
                        flag = true;
                    }
                } while (lado2 <= 0);

                do
                {
                    Console.Write("Ingrese la medida del tercer lado: ");
                    lado3 = Convert.ToInt32(Console.ReadLine());

                    if (lado3 <= 0)
                    {
                        Console.WriteLine("La medida debe ser positiva");
                    }
                    else
                    {
                        flag = true;
                    }
                } while (lado3 <= 0);

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine($"Los lados son: {lado1}cm, {lado2}cm, y {lado3}cm, por lo que es un triangulo equilatero.");
                }
                else if (lado1 == lado2 && lado3 != lado1)
                {
                    Console.WriteLine($"Los lados son: { lado1}cm, { lado2}cm, y {lado3}cm, por lo que es un triangulo isoceles.");
                }
                else { Console.WriteLine($"Los lados son: {lado1}cm, {lado2}cm, y {lado3}cm, por lo que es un triangulo escaleno."); }
            } while (!flag);
        }

        public void Ej8()
        {
            int numero;
            bool flag = false;
            int contador = 0;
            int acumulador = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                contador++;
                acumulador += numero;

                if (numero == 0)
                {
                    flag = true;
                    Console.WriteLine($"Contador = {contador}" + "\n" +
                        $"Acumulador = {acumulador}");
                }

            } while (!flag);
        }

        public void Ej9()
        {
            bool flag = false;
            int numeroOut;
            string numero;
            int contador = 0;

            do
            {
                Console.Write("Ingrese un numero entero menor a 100: ");
                numero = Console.ReadLine();


                if (!int.TryParse(numero, out numeroOut))
                {
                    Console.WriteLine("Ingresar el valor en formato numerico.");
                }
                else if (numeroOut <= 1 || numeroOut > 100)
                {
                    Console.WriteLine("Ingresar un valor positivo mayor a 1 y menor que 100.");
                }
                else
                {
                    flag = true;
                }
            } while(!flag);

            for (int i = 1; i <= numeroOut; i++)
            {
                if (numeroOut % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2) { Console.WriteLine("El numero ingresado es primo."); }
            else { Console.WriteLine("El numero ingresado no es primo."); }
        }

        public void Ej10()
        {
            int alumnos;
            int totalAlumnos = 0;
            byte curso;

            /*for (curso = 1; curso <= 255; curso++)
            {
                Console.Write($"Ingrese cantidad de alumnos inscriptos para el curso {curso}: ");
                alumnos = Convert.ToInt32(Console.ReadLine());

                if (alumnos > 99 || alumnos < 0)
                {
                    Console.WriteLine("Dato erroneo. Capacidad incorrecta.");
                    curso--;
                }
                else if (alumnos >= 1 && alumnos <= 99)
                {
                    totalAlumnos += alumnos;

                    Console.WriteLine($"Para el curso {curso}, hay {alumnos} alumnos.");
                }
                else if (alumnos == 0)
                {
                    Console.WriteLine($"En total hay {totalAlumnos} inscriptos.");
                    break;
                }
            }*/

            for (curso = 10; curso <= 255; curso += 10)
            {
                Console.Write($"Ingrese cantidad de alumnos inscriptos para el curso {curso}: ");
                alumnos = Convert.ToInt32(Console.ReadLine());

                if (alumnos < 1)
                {
                    Console.WriteLine("Dato erroneo. Capacidad incorrecta.");
                    curso -= 10;
                }
                else if (alumnos >= 1 && alumnos <= 99)
                {
                    totalAlumnos += alumnos;

                    Console.WriteLine($"Para el curso {curso}, hay {alumnos} alumnos.");
                }
                else if (alumnos > 99)
                {
                    Console.WriteLine($"En total hay {totalAlumnos} inscriptos.");
                    break;
                }
            }
        }

        public void Ej11()
        {
            bool flag = false;
            do
            {
                Console.Write("Ingrese su edad: ");
                string edad = Console.ReadLine();
                int edadOut;
                int cuota;

                if (!int.TryParse(edad, out edadOut))
                {
                    Console.WriteLine("Dato erroneo. Ingresar en formato numerico.");
                }
                else if (edadOut <= 0)
                {
                    Console.WriteLine("Dato erroneo. Numero ingresado invalido.");
                }
                else
                {
                    if (edadOut < 10)
                    {
                        cuota = 5;
                        Console.WriteLine($"Valor de cuota = ${cuota}.");
                    }
                    else if (edadOut < 18)
                    {
                        cuota = 15;
                        Console.WriteLine($"Valor de cuota = ${cuota}.");
                    }
                    else
                    {
                        cuota = 22;
                        Console.WriteLine($"Valor de cuota = ${cuota}.");
                    }
                    flag = true;
                }
                
            } while (!flag);

            bool flag2 = false;
            do
            {
                Console.Write("Desea hacer otra consulta? (S/N): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "s")
                {
                    Console.Write("Entendido.");
                }
                else
                {
                    Console.WriteLine("Saliendo.");
                    flag2 = true;
                }
            } while (!flag2);
        }

        public void Ej12()
        {
            int total = 0;

            for (int venta = 1; venta < 255; venta++)
            {
                Console.Write("Ingresar monto: ");
                int monto = Convert.ToInt32(Console.ReadLine());

                total += monto;

                Console.Write("Desea ingresar otro monto? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "n") 
                {
                    Console.WriteLine($"En {venta} ventas, el monto final es {total}.");
                    break; 
                }
            }
        }

        public void Ej13()
        {
            Console.Write("Ingrese la cantidad de materias aprobadas: ");
            byte matAprobadas = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese la cantidad de materias rendidas: ");
            byte matRendidas = Convert.ToByte(Console.ReadLine());

            Console.Write("Ingrese su promedio: ");
            float promedio = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la cantidad de materias faltantes: ");
            byte matFaltantes = Convert.ToByte(Console.ReadLine());

            byte bonMatFalt = 0;
            if (matFaltantes == 1) { bonMatFalt = 90; }
            else if (matFaltantes == 2) { bonMatFalt = 60; }
            else if (matFaltantes == 3) { bonMatFalt = 45; }
            else if (matFaltantes == 4) { bonMatFalt = 30; }
            else if (matFaltantes == 5) { bonMatFalt = 25; }
            else if (matFaltantes == 6) { bonMatFalt = 20; }
            else if (matFaltantes == 7) { bonMatFalt = 15; }
            else if (matFaltantes == 8) { bonMatFalt = 10; }
            else if (matFaltantes == 9) { bonMatFalt = 5; }

            float ranking = (matAprobadas / matRendidas) * 100 + matAprobadas * 3 + promedio * 3 + bonMatFalt;
            Console.WriteLine($"Su ranking es: {ranking}.");
        }

        public void Ej14()
        {
            for (int cliente = 1; cliente < 1000; cliente++)
            {
                int cantProd = 0;
                float monto = 0f;
                float descuento = 0f;

                for (int prod = 1;  prod < 1000; prod++)
                {
                    Console.Write("Ingrese precio del producto: ");
                    float precio = Convert.ToSingle(Console.ReadLine());

                    cantProd++;
                    monto += precio;

                    if (precio <= -2 || precio > 50)
                    {
                        Console.WriteLine("Precio incorrecto.");
                        cantProd--;
                        monto -= precio;
                        prod--;
                    }

                    if (precio == -1) 
                    {
                        cantProd--;
                        monto -= precio;
                        break; 
                    }
                }

                if (cantProd > 10 && monto <= 100f) { descuento = (monto * 0.015f); }

                else if (cantProd <= 10 && monto > 100f && monto <= 200f) { descuento = (monto * 0.03f); }

                else if (cantProd > 10 && monto > 100f && monto <= 200f) { descuento = (monto * 0.045f); }

                else if (cantProd <= 10 && monto > 200f && monto <= 300f) { descuento = (monto * 0.05f); }

                else if (cantProd > 10 && monto > 200f && monto <= 300f) { descuento = (monto * 0.065f); }

                else if (cantProd <= 10 && monto > 300f) { descuento = (monto * 0.07f); }

                else if (cantProd > 10 && monto > 300f) { descuento = (monto * 0.085f); }

                    Console.WriteLine($"Cant. productos: {cantProd}" + "\n" +
                        $"Monto {monto}" + "\n" +
                        $"Descuento: {-descuento}" + "\n" +
                        $"Total a pagar: {monto - descuento}");
            }
        }
    }
}
