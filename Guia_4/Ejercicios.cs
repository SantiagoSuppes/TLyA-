using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guia_4
{
    internal class Ejercicios
    {
        public void Ej1()
        {
            string[] nombreAlumnos = new string[5];
            bool flag = false;
            string nombre;
            string acumulador = "";

            for (int i = 0; i < nombreAlumnos.Length; i++)
            {
                do
                {
                    Console.Write($"Ingresar el nombre del alumno {i + 1}: ");
                    nombre = Console.ReadLine();

                    if (nombre == "")
                    {
                        Console.WriteLine("Error. No se permiten nombres vacios");
                    }
                    else { flag = true; }
                } while (!flag);

                nombreAlumnos[i] = nombre;
                acumulador += (nombre + Environment.NewLine);
            }
            Console.WriteLine(acumulador);
        }

        public void Ej2()
        {
            float[] sueldos = new float[8];
            string input;
            float sueldo;
            float acumulador = 0;


            for (int i = 0; i < sueldos.Length; i++)
            {
                bool flag = false;

                do
                {
                    Console.Write($"Ingresar el sueldo {i + 1}: ");
                    input = Console.ReadLine();

                    if (!float.TryParse(input, out sueldo))
                    {
                        Console.WriteLine("Error. Ingresar en formato numerico");
                    }
                    else if (sueldo < 1)
                    {
                        Console.WriteLine("Error. Rango ingresado invalido");
                    }
                    else { flag = true; }

                } while (!flag);

                sueldos[i] = sueldo;
                acumulador += sueldo;
            }
            Console.WriteLine(acumulador);
        }

        string[,] alumnos = new string[5, 2];
        public void Ej3()
        {
            int fila;
            string registro;
            string nombre;
            string acumulador = "";
            bool flag = false;
            int pos;

            for (fila = 0; fila < alumnos.GetLength(0); fila++)
            {

                do
                {
                    Console.Write($"Ingresar numero de registro del alumno {fila + 1}: ");
                    registro = Console.ReadLine();
                    flag = ValidarInt(registro);

                } while (!flag);

                do
                {
                    Console.Write($"Ingresar nombre del alumno {fila + 1}: ");
                    nombre = Console.ReadLine();
                    flag = !ValidarVacio(nombre);

                } while (flag);

                alumnos[fila, 0] = registro;
                alumnos[fila, 1] = nombre;

                acumulador += alumnos[fila, 0] + " " + nombre + Environment.NewLine;
            }

            Console.WriteLine(acumulador);

            // Ejercicio 4
            string respuesta;
            do
            {
                Console.Write("Ingresar registro de alumno a buscar: ");
                respuesta = Console.ReadLine();
                flag = ValidarInt(respuesta);

            } while (!flag);

            pos = BuscarAlumno(respuesta);

            if (pos == -1)
            {
                Console.WriteLine("No se hallaron alumnos.");
            }
            else
            {
                Console.WriteLine($"Alumno encontrado: {alumnos[pos, 0]}, {alumnos[pos, 1]}");
            }
        }

        public int BuscarAlumno(string registro)
        {
            int pos = -1;

            for (int fila = 0; fila < alumnos.GetLength(0); fila++)
            {
                if (alumnos[fila, 0] == registro)
                {
                    pos = fila;
                    break;
                }
            }
            return pos;
        }

        public bool ValidarInt(string input)
        {
            bool flag = false;

            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Error. Ingresar formato numerico");
            }
            else if (result < 0)
            {
                Console.WriteLine("Error. Rango negativo invalido");
            }
            else { flag = true; }

            return flag;
        }

        public bool ValidarFloat(string input, out float output)
        {
            bool flag = false;

            string corregido = input.Replace('.', ',');
            if (!float.TryParse(corregido, out output))
            {
                Console.WriteLine("Error. Ingresar formato numerico");
            }
            else if (output < 0)
            {
                Console.WriteLine("Error. Ingreso de valor invalido");
            }
            else { flag = true; }

            return flag;
        }

        public bool ValidarVacio(string input)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error. No se permiten campos vacios");
            }
            else { flag = true; }

            return flag;
        }

        //Ejercicio 5
        string[] personas = new string[5];

        public void Ej5()
        {

            bool flag = false;
            string nombre;
            string nombresIngresados = "";

            for (int i = 0; i < personas.Length; i++)
            {
                do
                {
                    Console.Write("Ingresar un nombre en la cadena: ");
                    nombre = Console.ReadLine();

                    if (ValidarVacio(nombre) && BuscarNombre(nombre) == -1)
                    {
                        flag = true;
                    }
                    else { flag = false; }

                } while (!flag);

                personas[i] = nombre;
                nombresIngresados += nombre + Environment.NewLine;
            }

            Console.WriteLine(nombresIngresados);
        }

        private int BuscarNombre(string nombre)
        {
            int pos = -1;

            for (int fila = 0; fila < personas.Length; fila++)
            {
                if (personas[fila] == nombre)
                {
                    pos = fila;
                    Console.WriteLine("Error. El nombre ya existe en los registros");
                }
            }

            return pos;
        }

        public void Ej6()
        {
            float[] sueldos = new float[8];
            float sueldo;
            bool flag = false;
            float acumulador = 0;
            float promedio = 0;

            for (int fila = 0; fila < sueldos.Length; fila++)
            {
                do
                {
                    Console.Write($"Ingresar sueldo {fila+1}/8: ");
                    string input = Console.ReadLine();

                    flag = ValidarFloat(input, out sueldo);

                } while (!flag);

                acumulador += sueldo;
                promedio = acumulador / sueldos.Length;
            }
            Console.WriteLine($"Total sueldos: {acumulador} \n" +
                $"Promedio: {promedio}");
        }

        public void Ej7()
        {
            float[] sueldosTM = new float[4];
            float[] sueldosTT = new float[4];
            bool flag = false;
            float sueldo;
            float acumuladorTM = 0;
            float acumuladorTT = 0;


            for (int fila = 0; fila < sueldosTM.Length; fila++)
            {
                do
                {
                    Console.Write($"Ingresar sueldo TM {fila + 1}/4: ");
                    string input = Console.ReadLine();

                    flag = ValidarFloat(input, out sueldo);

                } while (!flag);

                acumuladorTM += sueldo;
            }

            for (int fila = 0; fila < sueldosTT.Length; fila++)
            {
                do
                {
                    Console.Write($"Ingresar sueldo TT {fila + 1}/4: ");
                    string input = Console.ReadLine();

                    flag = !ValidarFloat(input, out sueldo);

                } while (flag);

                acumuladorTT += sueldo;
            }

            Console.WriteLine($"Sueldos turno mañana. Total: {acumuladorTM}" + Environment.NewLine + 
                $"Sueldos turno tarde. Total: {acumuladorTT}");
        }

        public void Ej8()
        {
            float[,] notas = new float[3, 5];
            int ultimaFila = notas.GetLength(0);
            float registroAl;
            float teorico1 = 0;
            float teorico2 = 0;
            float practico1 = 0;
            float practico2 = 0;
            float sumaActual = 0;
            float promedioActual = 0;
            bool flag = false;
            float acumulador = 0;
            float acumuladorT = 0;
            float acumuladorP = 0;
            int promocionados = 0;
            int regularizados = 0; 
            int desaprobados = 0;

            for (int i = 0; i < ultimaFila; i++)
            {
                do
                {
                    Console.Write("Ingresar registro del alumno: ");
                    string registro = Console.ReadLine();
                    flag = ValidarFloat(registro, out registroAl);

                } while (!flag);
                notas[i,0] = registroAl;

                do
                {
                    Console.Write("Ingresar nota teorico 1: ");
                    string respuesta = Console.ReadLine();
                    flag = !ValidarFloat(respuesta, out teorico1);
                } while (flag);
                notas[i,1] = teorico1;

                do
                {
                    Console.Write("Ingresar nota teorico 2: ");
                    string respuesta = Console.ReadLine();
                    flag = ValidarFloat(respuesta, out teorico2);
                } while (!flag);
                notas[i,2] = teorico2;

                do
                {
                    Console.Write("Ingresar nota practico 1: ");
                    string respuesta = Console.ReadLine();
                    flag = !ValidarFloat(respuesta, out practico1);
                } while (flag);
                notas[i,3] = practico1;

                do
                {
                    Console.Write("Ingresar nota practico 2: ");
                    string respuesta = Console.ReadLine();
                    flag = ValidarFloat(respuesta, out practico2);
                } while (!flag);
                notas[i,4] = practico2;

                sumaActual = teorico1 + teorico2 + practico1 + practico2;
                promedioActual = (sumaActual / 4);

                acumuladorT += teorico1 + teorico2;
                acumuladorP += practico1 + practico2;
                acumulador += sumaActual;

                if (promedioActual < 3.50) { desaprobados++; }
                else if (promedioActual < 6.50) { regularizados++; }
                else { promocionados++; }
            }
            float promedioGral = acumulador / (4*ultimaFila);
            float promTeorico = acumuladorT / (2*ultimaFila);
            float promPractico = acumuladorP / (2*ultimaFila);

            Console.WriteLine($"El promedio general es: {promedioGral} \n" +
                $"El promedio teorico es {promTeorico} \n" +
                $"El promedio practico es {promPractico}");

            Console.WriteLine($"Cantidad de promocionados: {promocionados} \n" +
                $"Cantidad de regularizados: {regularizados} \n" +
                $"Cantidad de desaprobados: {desaprobados}");

            for (int i = 0; i < ultimaFila; i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write(notas[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        string[,] productos = new string[3, 3];
        public void Ej9()
        {
            string nombre;
            string cantidad;
            string precio;
            float precioOut;
            bool flag = false;
            float valorTotal = 0;

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                do
                {
                    Console.Write($"Ingresar nombre del producto {i+1}: ");
                    nombre = Console.ReadLine().ToLower();
                    flag = ValidarVacio(nombre);

                } while (!flag );

                productos[i, 0] = nombre;

                do
                {
                    Console.Write("Ingresar cantidad en kg: ");
                    cantidad = Console.ReadLine();
                    flag = !ValidarInt(cantidad);

                } while (flag);

                productos[i, 1] = cantidad;

                do
                {
                    Console.Write("Ingresar precio por kg: ");
                    precio = Console.ReadLine();
                    flag = ValidarFloat(precio, out precioOut);

                } while (!flag);

                productos[i, 2] = precio;

                valorTotal += Convert.ToSingle(cantidad) * precioOut;
            }

            Console.WriteLine($"El valor total del stock existente es: {valorTotal}");

            for (int i = 0; i < productos.GetLength(0); i++)
            {
                for (int j = 0; j < productos.GetLength(1); j++)
                {
                    Console.Write(productos[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Ej10() 
        {
            Console.Write("Ingresar nombre del producto: ");
            string respuesta = Console.ReadLine();
            int pos = BuscarProducto(respuesta);


            if (pos == -1)
            {
                Console.WriteLine("Producto no encontrado.");
            }
            else 
            {
                float pdv = Convert.ToSingle(productos[pos, 2]) * 1.1f;
                Console.WriteLine($"El precio de venta es {pdv}");
            }
        }

        public int BuscarProducto(string producto)
        {
            int pos = -1;

            for (int i = 0; i < productos.GetLength(0); i++) 
            {
                if (producto == productos[i, 0])
                {
                    pos = i;
                }
            }
            return pos;
        }

        public void Ej11() 
        {
            string nuevaCantidad;
            string nuevoPrecio = "";
            float precioOut = 0;

            Console.Write("Ingresar nombre del producto a actualizar: ");
            string producto = Console.ReadLine().ToLower();
            int pos = BuscarProducto(producto);

            string stockAnterior = "";
            string precioAnterior = "";

            if (pos == -1) 
            {
                Console.WriteLine("El producto no existe");
            }
            else
            {
                bool flag = false;
                stockAnterior = productos[pos, 1];
                precioAnterior = productos[pos, 2];

                do
                {
                    Console.Write("Ingresar nueva cantidad adquirida (kg): ");
                    nuevaCantidad = Console.ReadLine();
                    flag = ValidarInt(nuevaCantidad);

                }while (!flag);
                productos[pos, 1] = nuevaCantidad;

                do
                {
                    Console.Write("Ingresar nuevo costo: ");
                    nuevoPrecio = Console.ReadLine();
                    flag = !ValidarFloat(nuevoPrecio, out precioOut);

                } while (flag);

                if (stockAnterior == "0")
                {
                    productos[pos, 2] = nuevoPrecio;
                }
                else
                {
                    float costoPromedio = (Convert.ToSingle(precioAnterior) + precioOut) / 2;
                    productos[pos, 2] = costoPromedio.ToString();
                }

                Console.WriteLine(productos[pos, 2]);
            }
        }
    }
}
