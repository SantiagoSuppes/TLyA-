using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Guia_6
{
    internal class Ejercicios
    {
        private List<int> registros = [];

        public void Ej1()
        {
            bool flag = false;
            bool flagAux = false;

            do
            {
                Console.Write("Ingresar un registro: ");
                int registro = Convert.ToInt32(Console.ReadLine());
                registros.Add(registro);

                do
                {
                    Console.Write("Desea continuar agregando? (S/N): ");
                    string respuesta = Console.ReadLine().ToUpper();

                    if (respuesta == "S") { flagAux = true; flag = false; }
                    else if (respuesta == "N") { flagAux = true; flag = true; }
                    else { flagAux = false;  Console.WriteLine("Error, seleccionar opcion S o N."); }

                } while (!flagAux);

            } while (!flag);

            ImprimirLista();
        }

        private void ImprimirLista()
        {
            foreach(int registro in registros)
            {
                 Console.Write(registro + " ");
            }
        }

        public void Ej2()
        {
            Ej1(); 
            Console.WriteLine(Environment.NewLine + "Cantidad: " + registros.Count);
        }

        public void Ej3()
        {
            Ej2();
            int indice = 0;
            registros.RemoveAt(indice);
            Console.WriteLine("Registro {0} eliminado", indice);
            ImprimirLista();
        }

        public void Ej4()
        {
            Ej2();
            Console.Write("Ingresar el registro que se eliminara posteriormente: ");
            int registro = Convert.ToInt32(Console.ReadLine());         //Nuevamente sin validar.

            registros.Add(registro);
            ImprimirLista();
            Console.WriteLine(Environment.NewLine + "Procediendo a la eliminacion.");
            registros.Remove(registro);
            ImprimirLista();
        }

        public void Ej5()
        {
            Ej2();
            Console.Write("Ingresar el registro a eliminar: ");
            int respuesta = Convert.ToInt32(Console.ReadLine());

            if (registros.Contains(respuesta))
            {
                registros.Remove(respuesta);
                Console.WriteLine("Elemento eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Error. Ese elemento puede no existir o estar mal escrito.");
            }
            ImprimirLista();
        }
        
        public List<Alumno> alumnos = new List<Alumno>();

        public void AgregarAlumno() //Ejercicio 9
        {
            bool flag = false;
            bool flagAux = false;

            do
            {
                for (int i = 0; i < 100; i++)
                {
                    Alumno alumno = new Alumno();
                    Console.Write($"{i} Ingresar registro: ");
                    int registro = Convert.ToInt32(Console.ReadLine());
                    alumno.NroRegistro = registro;

                    Console.Write($"{i} Ingresar nombre: ");
                    string nombre = Console.ReadLine();
                    alumno.Nombre = nombre;

                    Console.Write($"{i} Ingresar apellido: ");
                    string apellido = Console.ReadLine();
                    alumno.Apellido = apellido;

                    Console.Write($"{i} Cantidad de materias aprobadas? ");
                    byte matAp = Convert.ToByte(Console.ReadLine());
                    alumno.MateriasAprobadas = matAp;

                    Console.Write($"{i} Cantidad de materias restantes? ");
                    byte matRes = Convert.ToByte(Console.ReadLine());
                    alumno.MateriasRestantes = matRes;

                    Console.Write($"{i} Ingresar promedio (utilice coma en vez de punto): ");
                    float promedio = Convert.ToSingle(Console.ReadLine());
                    alumno.Promedio = promedio;

                    alumnos.Add(alumno);

                    do
                    {
                        Console.Write("Desea continuar agregando? (S/N): ");
                        string respuesta = Console.ReadLine().ToUpper();

                        if (respuesta == "S") { flagAux = true; flag = false; }
                        else if (respuesta == "N") { flagAux = true; flag = true; }
                        else { flagAux = false; Console.WriteLine("Error, seleccionar opcion S o N."); }

                    } while (!flagAux);

                    if (flag) { break; }
                }

            } while (!flag);
            
            foreach (var alumno in alumnos) {  Console.WriteLine(alumno.ToString()); }

        }

        public Alumno BuscarAlumno(int nroRegistro) // Ejercicio 10
        {
            return alumnos.Find(a => a.NroRegistro == nroRegistro);
        }

        public void Ej11()
        {
            AgregarAlumno();
            bool flag = false;
            int registroOut;
            do
            {
                Console.Write("Ingresar registro del alumno a buscar: ");
                string registro = Console.ReadLine();
                flag = ValidarRegistro(registro, out registroOut);

            } while (!flag);

            BuscarAlumno(registroOut);
            if (BuscarAlumno(registroOut) == null) { Console.WriteLine("Alumno no encontrado."); }
            else { Console.WriteLine("Alumno encontrado: " + Environment.NewLine + BuscarAlumno(registroOut)); }

        }

        private static bool ValidarRegistro(string registro, out int registroOut)
        {
            bool flag = false;

            if (!int.TryParse(registro, out registroOut))
            {
                Console.WriteLine("Error. Ingresar formato numerico.");
            }
            else if (registroOut < 0)
            {
                Console.WriteLine("Error. Ingresar registros en rango positivo.");
            }
            else { flag = true; }
            return flag;
        }

        public void Ej12()
        {
            AgregarAlumno();
            bool flag = false;
            int registroOut;
            do
            {
                Console.Write("Ingresar registro del alumno a buscar: ");
                string registro = Console.ReadLine();
                flag = ValidarRegistro(registro, out registroOut);

            } while (!flag);

            Alumno alumno = BuscarAlumno(registroOut);
            if (alumno == null) { Console.WriteLine("Alumno no encontrado."); }
            else 
            { 
                Console.WriteLine("Alumno encontrado: " + Environment.NewLine + BuscarAlumno(registroOut));
                Console.WriteLine("Aprobando materia...");
                alumno.AprobarMateria();
                if (alumno.MateriasRestantes == 0)
                {
                    Console.WriteLine("Felicitaciones, estas recibido!");
                }
                else
                {
                    Console.WriteLine($"Te quedan {alumno.MateriasRestantes} materias para recibirte.");
                }
            }
        }

        public void PromedioGral()          // Ejercicio 13
        {
            AgregarAlumno();
            int contador = 0;
            float acumulador = 0;
            foreach (var alumno in alumnos)
            {
                contador ++;
                acumulador += alumno.Promedio;
            }
            Console.WriteLine($"El promedio general es: {acumulador/contador}");
        }

        public void OrdenarListaxReg()          // Ejercicio 14: ordenamiento ascendente por Nro. registro
        {
            AgregarAlumno();
            int regAct;
            int regPost;
            int pasadas = 0;
            do
            {
                int pos = 0;

                do
                {
                    Alumno alumno1 = alumnos[pos];
                    Alumno alumno2 = alumnos[pos + 1];
                    regAct = alumno1.NroRegistro;
                    regPost = alumno2.NroRegistro;

                    if (regAct > regPost)
                    {
                        var aux = alumno1;
                        alumnos[pos] = alumno2;
                        alumnos[pos + 1] = aux;
                    }
                    pos++;

                } while (pos < alumnos.Count - 1);

                pasadas++;

            } while (pasadas < alumnos.Count - 1);
            
            Console.WriteLine("Realizando ordenamiento...");
            foreach (var alumno in alumnos) { Console.WriteLine(alumno.ToString()); }
        }

        public void OrdenarListaxNyA()           // Ejercicio 15: ordena la lista ascendente por Nombre y apellido.
        {
            AgregarAlumno();
            int regAct;
            int regPost;
            int pasadas = 0;
            do
            {
                int pos = 0;

                do
                {
                    Alumno alumno1 = alumnos[pos];
                    Alumno alumno2 = alumnos[pos + 1];

                    if (string.Compare(alumno1.Apellido, alumno2.Apellido) > 0 )
                    {
                        var aux = alumno1;
                        alumnos[pos] = alumno2;
                        alumnos[pos + 1] = aux;
                    }
                    else if (string.Compare(alumno1.Apellido, alumno2.Apellido) == 0)
                    {
                        if (string.Compare(alumno1.Nombre, alumno2.Nombre) > 0)
                        {
                            var aux = alumno1;
                            alumnos[pos] = alumno2;
                            alumnos[pos + 1] = aux;
                        }
                    }

                    pos++;

                } while (pos < alumnos.Count - 1);

                pasadas++;

            } while (pasadas < alumnos.Count - 1);

            Console.WriteLine("Realizando ordenamiento...");
            foreach (var alumno in alumnos) { Console.WriteLine(alumno.ToString()); }
        } 
    

        public void Ej16()
        {
            AgregarAlumno();
            int cant = alumnos.Count(a => a.Promedio > 7);
            Console.WriteLine($"Cantidad de alumnos con promedio superior a 7: {cant}");
        }

        public void Ej17()
        {
            AgregarAlumno();
            var cant = alumnos.FindAll(a => a.MateriasRestantes < 5);
            Console.WriteLine(cant);
        }

        public void PromMin()
        {
            AgregarAlumno();
            var min = alumnos.Min(a => a.Promedio);
        }

        public void PromMax() 
        {
            AgregarAlumno();
            var max = alumnos.Max(a => a.Promedio);
        }
    }
}
