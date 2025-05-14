using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guia_3
{
    internal class Ejercicios
    {
        // Ejercicio 1
        public void Ingreso30()
        {
            int ingreso = 30;
            Console.WriteLine($"Valor inicial: {ingreso}");

            IngresoPorValor(ingreso);
            Console.WriteLine($"Valor despues de ingresoPorValor(): {ingreso}");

            IngresoPorRef(ref ingreso);
            Console.WriteLine($"Valor despues de ingresoPorRef(): {ingreso}");
        }

        public void IngresoPorValor(int ingresoValor)
        {
            ingresoValor = 40;
        }

        public void IngresoPorRef(ref int ingresoRef)
        {
            ingresoRef = 40;
        }

        // Ejercicio 2

        public void Varnum()
        {
            Console.Write("Ingrese un valor numerico: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese otro valor numerico: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = Suma(num1, num2);
            Console.WriteLine($"Resultado: {resultado}");
        }

        public int Suma(int num1,int num2)
        {
            return num1 + num2;
        }

        // Ejercicio 3

        public void Principal( int var1, int var2)
        {
            Console.WriteLine($"Valores: {var1} y {var2}");

            Intercambio(ref var1,ref var2);

            Console.WriteLine($"Valores despues del intercambio: {var1} y {var2}");
        }

        public void Intercambio(ref int v1, ref int v2)
        {
            v1 = 80;
            v2 = 100;
        }

        // Ejercicio 4
        
        public void Principal4()
        {
            Console.WriteLine(NumeroDel1al10());
        }

        public int NumeroDel1al10()
        {
            bool flag = false;
            int numeroOut;
            do
            {
                Console.Write("Ingrese un numero del 1 al 10: ");
                string numero = Console.ReadLine();

                if (!int.TryParse(numero, out numeroOut))
                {
                    Console.WriteLine("Ingresar formato numerico.");
                }
                else if (numeroOut < 1 || numeroOut > 10)
                {
                    Console.WriteLine("Rango invalido.");
                }
                else { flag = true; }

            } while (!flag);

            return numeroOut;

        }

        //Ejercicio 5

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public void Principal5()
        {
            int numeroOut1;
            int numeroOut2;
            bool flag1 = false;
            bool flag2 = false;
            do
            {
                Console.Write("Ingresar un numero: ");
                string num1 = Console.ReadLine();

                if (!int.TryParse(num1, out numeroOut1))
                {
                    Console.WriteLine("Ingresar formato numerico.");
                }
                else if (numeroOut1 < 1)
                {
                    Console.WriteLine("Ingresar valores positivos.");
                }
                else { flag1 = true; }

            } while (!flag1);
            do
            {
                Console.Write("Ingresar otro numero: ");
                string num2 = Console.ReadLine();

                if (!int.TryParse(num2, out numeroOut2))
                {
                    Console.WriteLine("Ingresar formato numerico.");
                }
                else if (numeroOut2 < 1)
                {
                    Console.WriteLine("Ingresar valores positivos.");
                }
                else { flag2 = true; }

            } while (!flag2);

            int resultado = Multiplicar(numeroOut1, numeroOut2);
            Console.WriteLine($"Resultado: {resultado}");
        }

        // Ejercicio 6

        public int ValidarCodigo()
        {
            bool flag = false;
            int codigoOut;
            do
            {
                Console.Write("Ingrese el codigo: ");
                string codigo = Console.ReadLine();

                if (!int.TryParse(codigo, out codigoOut))
                {
                    Console.WriteLine("Ingresar en formato numerico.");
                }
                else if (codigoOut < 1 || codigoOut > 999)
                {
                    Console.WriteLine("Fuera de rango.");
                }
                else { flag = true; }

            } while (!flag);

            return codigoOut;
        }

        public string ValidarDescripcion()
        {
            bool flag = false;
            string descripcion;
            do
            {
                Console.Write("Ingresar la descripcion: ");
                descripcion = Console.ReadLine();

                if (string.IsNullOrEmpty(descripcion))
                {
                    Console.WriteLine("No ingresar texto vacio.");
                }
                else if (descripcion.Length > 150)
                {
                    Console.WriteLine("No debe superar los 150 caracteres.");
                }
                else { flag = true; }

            } while (!flag);

            return descripcion;
        }

        public float ValidarPrecio()
        {
            int precioOut = 0;
            bool flag = false;

            do
            {
                Console.Write("Ingresar el precio: ");
                string precio = Console.ReadLine();

                if (!int.TryParse(precio, out precioOut))
                {
                    Console.WriteLine("Ingresar en formato numerico");
                }
                else if (precioOut < 1)
                {
                    Console.WriteLine("Valor incorrecto.");
                }
                else { flag = true; }

            } while (!flag);

            return precioOut;
        }

        public void Principal6()
        {
            Console.WriteLine($"El producto tiene las siguientes caracteristicas:" + "\n" +
                $"Codigo: {ValidarCodigo()}" + "\n" +
                $"Descripcion: {ValidarDescripcion()}" + "\n" +
                $"Precio: {ValidarPrecio()}");
        }

        // Ejercicio 7
        public void Principal7()
        {
            float montoOut;
            bool flag = false;

            do
            {
                Console.Write("Ingresar monto: ");
                string monto = Console.ReadLine();

                if (!float.TryParse(monto, out montoOut))
                {
                    Console.WriteLine("Ingresar formato numerico.");
                }
                else if (montoOut < 1)
                {
                    Console.WriteLine("Valor invalido.");
                }
                else { flag = true; }

            } while (!flag);

            Console.WriteLine($"El valor final de la compra es: {montoOut - CalcularDescuento(ref montoOut)}" + "\n"
                                + $"Monto: {montoOut}" + "\n"
                                + $"Descuento: -{CalcularDescuento(ref montoOut)}");
        }
        public float CalcularDescuento(ref float monto)
        {
            float descuento = 0f;
            

            if (monto <= 1000)
            {
                descuento = 0.1f;
            }
            else if (monto > 1000 && monto <= 10000)
            {
                descuento = 0.15f;
            }
            else if (monto > 10000 && monto <= 100000)
            {
                descuento = 0.2f;
            }
            else if (monto > 100000)
            {
                descuento = 0.25f;
            }


            return descuento *= monto;
        }

        // Ejercicio 8
        public void Principal8()
        {
            string operacion;
            float op1;
            float op2;
            float resultado;
            bool flag = false;

            do
            {
                Console.WriteLine("Eliga una de las siguientes opciones: \n" +
                    "1. Suma (+) \n" +
                    "2. Resta (-) \n" +
                    "3. Division (/) \n" +
                    "4. Multiplicacion (*) \n" +
                    "5. Potenciacion (^) \n" +
                    "9. Salir"); 

                operacion = Console.ReadLine();

                if (operacion == "1" || operacion == "2" || operacion == "4" || operacion == "5")
                {
                    op1 = IngValOperando(-1000, 1000);
                    op2 = IngValOperando(-100, 100);
                    resultado = CalcularOperacion(operacion, op1, op2);
                    MostrarResultado(operacion, op1, op2, resultado);
                }
                else if (operacion == "3")
                {
                    op1 = IngValOperando(-1000, 1000);
                    op2 = IngValOperando(-100, 100);

                    if (op1 == 0 || op2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                    }
                    else
                    {
                        resultado = CalcularOperacion(operacion, op1, op2);
                        MostrarResultado(operacion, op1, op2, resultado);
                    }
                }
                else if (operacion == "9")
                {
                    Console.WriteLine("Esta seguro que desea salir? (s/n): ");
                    string respuesta = Console.ReadLine().ToUpper();

                    if (respuesta == "S")
                    {
                        Console.WriteLine("Saliendo...");
                        flag = true;
                    }
                    else if (respuesta == "N") { Console.WriteLine("Volviendo..."); }
                }

            } while (!flag);
        }

        public float IngValOperando(int limInf, int limSup)
        {
            float operandoOut;
            bool flag = false;

            do
            {
                Console.Write("Ingresar valor del operando: ");
                string operando = Console.ReadLine();

                if (!float.TryParse(operando, out operandoOut))
                {
                    Console.WriteLine("Ingresar formato numerico.");
                }
                else if (operandoOut < limInf || operandoOut > limSup)
                {
                    Console.WriteLine("Rango excedido.");
                }
                else { flag = true; }

            } while (!flag);

            return operandoOut;
        }

        public float CalcularOperacion(string operacion, float op1, float op2)
        {
            float resultado = 0;
            switch (operacion)
            {
                case "1": resultado = op1 + op2; break;
                case "2": resultado = op1 - op2; break;
                case "3":
                    if (op1 == 0 || op2 == 0)
                    {
                        break;
                    }
                    else { resultado = op1 / op2; break; }            
                case "4": resultado = op1 * op2; break;
                case "5": resultado = Convert.ToSingle(Math.Pow(op1, op2)); break;
            }
                return resultado;
        }

        public void MostrarResultado(string operacion, float op1, float op2, float resultado)
        {
            switch (operacion)
            {
                case "1": operacion = "+"; break;
                case "2": operacion = "-"; break;
                case "3": operacion = "/"; break;
                case "4": operacion = "*"; break;
                case "5": operacion = "^"; break;
            }

            Console.WriteLine($"{op1} {operacion} {op2} = {resultado}");
        }

        // Ejercicio 9

        public void Principal9()
        {
            bool flag = false;
            float op1;
            float op2;
            float resultado = 0;

            do
            {
                Console.WriteLine("Eliga una de las siguientes opciones: \n" +
                "1. Suma (+) \n" +
                "2. Resta (-) \n" +
                "3. Division (/) \n" +
                "4. Multiplicacion (*) \n" +
                "5. Potenciacion (^) \n" +
                "9. Salir");

                string operacion = Console.ReadLine();

                if (operacion == "1" || operacion == "2" || operacion == "4" || operacion == "5")
                {
                    op1 = IngValOperando(-1000, 1000);
                    op2 = IngValOperando(-100, 100);

                    switch (operacion)
                    {
                        case "1":
                            resultado = CalcularSuma(op1, op2);
                            break;
                        case "2":
                            resultado = CalcularResta(op1, op2);
                            break;
                        case "4":
                            resultado = CalcularMultiplicacion(op1, op2);
                            break;
                        case "5":
                            resultado = CalcularPotencia(op1, op2);
                            break;
                    }

                    MostrarResultado(operacion, op1, op2, resultado);
                }
                else if (operacion == "3")
                {
                    op1 = IngValOperando(-1000, 1000);
                    op2 = IngValOperando(-100, 100);

                    if (op1 == 0 || op2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                    }
                    else
                    {
                        resultado = CalcularDivision(op1, op2);
                        MostrarResultado(operacion, op1, op2, resultado);
                    }
                }
                else if (operacion == "9")
                {
                    Console.WriteLine("Esta seguro que desea salir? (s/n): ");
                    string respuesta = Console.ReadLine().ToUpper();

                    if (respuesta == "S")
                    {
                        Console.WriteLine("Saliendo...");
                        flag = true;
                    }
                    else if (respuesta == "N")
                    {
                        Console.WriteLine("Volviendo...");
                    }
                }

            } while (!flag) ;
        }
        public float CalcularSuma(float op1, float op2)
        {
            return op1 + op2;
        }
        public float CalcularResta(float op1, float op2)
        {
            return op1 - op2;
        }
        public float CalcularDivision(float op1, float op2)
        {
            return op1 / op2;
        }
        public float CalcularMultiplicacion(float op1, float op2)
        {
            return op1 * op2;
        }
        public float CalcularPotencia(float op1, float op2)
        {
            return Convert.ToSingle(Math.Pow(op1, op2));
        }
    }
}
