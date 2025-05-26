using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5
{
    internal class Ejercicios
    {
        public class Persona
        {
            public int DNI { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public byte Edad {  get; set; }
            public string Genero { get; set; }

            public Persona()
            {
                Console.WriteLine("Estas utilizando el constructor sin parametros.");
            }
            public Persona(int dNI, string nombre, string apellido, string fechaNacimiento, byte edad, string genero)
            {
                this.DNI = dNI;
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.FechaNacimiento = Convert.ToDateTime(fechaNacimiento);
                this.Edad = edad;
                this.Genero = genero;
                
            }
            public override string ToString()
            {
                return DNI + "-" + Nombre + '-' + Apellido + '-' + FechaNacimiento.ToString("dd/MM/yyyy") + '-' + Edad + '-' + Genero;
            }

            public void Saludar()
            {
                Console.WriteLine($"Hola Mundo! Mi nombre completo es {Nombre} {Apellido}, y tengo {Edad} anios.");
            }

            public void CumplirAnios()
            {
                Edad++;
            }

            public void MostrarDatos()
            {
                Console.WriteLine(ToString());
            }

            public bool EsMayorDeEdad()
            {
                bool flag = true;

                if (Edad < 18)
                {
                    flag = false;
                    Console.WriteLine("Ingreso denegado. Es menor de edad.");
                }
                else { Console.WriteLine("Ingreso admitido. Es mayor de edad."); }
                return flag;
            }
        }
    }
}
