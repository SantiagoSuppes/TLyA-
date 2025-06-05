using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7
{
    internal class Alumno
    {
        public int NroRegistro { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public byte MateriasAprobadas { get; set; }
        public byte MateriasRestantes { get; set; }
        public float Promedio { get; set; }
        public Alumno() { }
        public Alumno(int nroRegistro, string nombre, string apellido, byte materiasAprobadas, byte materiasRestantes, float promedio)
        {
            NroRegistro = nroRegistro;
            Nombre = nombre;
            Apellido = apellido;
            MateriasAprobadas = materiasAprobadas;
            MateriasRestantes = materiasRestantes;
            Promedio = promedio;
        }

        public override string ToString()
        {
            return string.Format($"Nro Registro: {NroRegistro} - Nombre: {Nombre} - Apellido: {Apellido} - " +
                $"MateriasAprobadas: {MateriasAprobadas} - MateriasRestantes: {MateriasRestantes} - Promedio: {Promedio}");
        }

        public void AprobarMateria() // Ejercicio 8
        {
            this.MateriasAprobadas++;
            this.MateriasRestantes--;
        }
    }
}
