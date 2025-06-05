using System.Net.NetworkInformation;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guia_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Alumno> alumnos = new List<Alumno>();
        string path = "C:\\Users\\santi\\source\\repos\\Guia_7\\Alumnos.txt";


        static string ValidarString(string str, string campo)
        {
            string error;

            if (string.IsNullOrEmpty(str))
            {
                error = $"El campo {campo} no debe estar vacio." + Environment.NewLine;
            }
            else { error = ""; }

            return error;
        }

        static string ValidarInt(string num, string campo, out int numOut)
        {
            string error;

            if (!int.TryParse(num, out numOut))
            {
                error = $"El campo {campo} debe ser en formato numerico entero." + Environment.NewLine;
            }
            else if (numOut <= 0)
            {
                error = $"El campo {campo} debe ser positivo" + Environment.NewLine;
            }
            else { error = ""; }

            return error;
        }

        static string ValidarByte(string num, string campo, out byte numOut)
        {
            string error;

            if (!byte.TryParse(num, out numOut))
            {
                error = $"El campo {campo} debe ser en formato numerico entero, máximo 255" + Environment.NewLine;
            }
            else if (numOut < 0)
            {
                error = $"El campo {campo} debe ser positivo" + Environment.NewLine;
            }
            else { error = ""; }

            return error;
        }

        static string ValidarPromedio(string num, string campo, out float numOut)
        {
            string error;

            if (!float.TryParse(num, out numOut))
            {
                error = $"El campo {campo} debe ser en formato numerico." + Environment.NewLine;
            }
            else if (numOut < 1 || numOut > 10)
            {
                error = $"El campo {campo} debe tener rango [1-10]" + Environment.NewLine;
            }
            else { error = ""; }

            return error;
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {

            // Variables de entrada
            string numReg = txtNroRegistro.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string matAp = txtMatAp.Text;
            string matRes = txtMatRes.Text;
            string prom = txtPromedio.Text;
            string errores = "";

            // Variables de salida
            int regOut;
            float promOut;
            byte matApOut;
            byte matResOut;

            errores += ValidarInt(numReg, "Numero de registro", out regOut);
            errores += ValidarString(nombre, "Nombre");
            errores += ValidarString(apellido, "Apellido");
            errores += ValidarByte(matAp, "Materias aprobadas", out matApOut);
            errores += ValidarByte(matRes, "Materias restantes", out matResOut);
            errores += ValidarPromedio(prom, "Promedio", out promOut);

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show(errores, "Error");
            }
            else
            {
                Alumno alumno = new Alumno(regOut, nombre, apellido, matApOut, matResOut, promOut);

                alumnos.Add(alumno);
                ListaAlumnos.Items.Add(regOut + "-" + nombre + "-" + apellido + "-" + matApOut + "-" + matResOut + "-" + promOut);
                LimpiarCamposAlumno();
            }

        }

        private void LimpiarCamposAlumno()
        {
            txtNroRegistro.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtMatAp.Clear();
            txtMatRes.Clear();
            txtPromedio.Clear();

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string msj = "";

            foreach (Alumno alumno in alumnos)
            {
                msj += alumno.ToString() + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(msj))
            {
                MessageBox.Show("No hay alumnos registrados.", "Mensaje");
            }
            else
            {
                MessageBox.Show(msj, "Mensaje");
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string regIn = txtRegistroBuscar.Text;
            string error = "";
            int regOut;
            int regFound;


            error += ValidarInt(regIn, "Nro. registro", out regOut);

            if (string.IsNullOrEmpty(error))
            {
                Alumno alumnoEncontrado = null;

                foreach (Alumno alumno in alumnos)
                {
                    if (alumno.NroRegistro == regOut)
                    {
                        alumnoEncontrado = alumno;
                        break;
                    }
                }

                if (alumnoEncontrado == null)
                {
                    MessageBox.Show("El alumno no existe en los registros.", "Alumno no encontrado");
                }
                else
                {
                    MessageBox.Show(alumnoEncontrado.ToString(), "Alumno encontrado");
                }
            }
            else { MessageBox.Show(error, "Error"); }

            LimpiarCamposBuscar();
        }

        private Alumno BuscarAlumno(int nroRegistro)
        {
            return alumnos.Find(a => a.NroRegistro == nroRegistro);
        }

        private void LimpiarCamposBuscar()
        {
            txtRegistroBuscar.Clear();

        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (ListaAlumnos.Items.Count == 0)
            {
                MessageBox.Show("No hay alumnos en la lista.", "Invalid");
            }
            else if (ListaAlumnos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar un alumno de la lista para eliminar.", "Invalid");
            }
            else
            {
                string[] alumno = ListaAlumnos.SelectedItems.ToString().Split('-');
                Alumno alumnoAEliminar = BuscarAlumno(Convert.ToInt32(alumno[0]));

                alumnos.Remove(alumnoAEliminar);
                ListaAlumnos.Items.Remove(ListaAlumnos.SelectedItem);

                MessageBox.Show("Se elimino el alumno seleccionado.", "Notificacion");
            }
        }

        private void btnMostrarDistinciones_Click(object sender, EventArgs e)
        {
            string alumnosAMostrar = "";

            if (rbDistincion1.Checked)
            {
                foreach (Alumno alumno in alumnos)
                {
                    if (alumno.Promedio >= 9)
                    {
                        alumnosAMostrar += alumno.NroRegistro.ToString() + Environment.NewLine;
                    }
                }
            }
            else if (rbDistincion2.Checked)
            {
                foreach (Alumno alumno in alumnos)
                {
                    if (alumno.Promedio >= 8 && alumno.Promedio < 9)
                    {
                        alumnosAMostrar += alumno.NroRegistro.ToString() + Environment.NewLine;
                    }
                }
            }
            else if (rbDistincion3.Checked)
            {
                foreach (Alumno alumno in alumnos)
                {
                    if (alumno.Promedio >= 7 && alumno.Promedio < 8)
                    {
                        alumnosAMostrar += alumno.NroRegistro.ToString() + Environment.NewLine;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una distincion.", "Invalid");
                return;
            }

            if (string.IsNullOrEmpty(alumnosAMostrar))
            {
                MessageBox.Show("No existen alumnos con estas distinciones.", "Distinciones");
                return;
            }


            MessageBox.Show(alumnosAMostrar + Environment.NewLine, "Distinciones");

            LimpiarChecksDistincion();
        }

        private void LimpiarChecksDistincion()
        {
            rbDistincion1.Checked = false;
            rbDistincion2.Checked = false;
            rbDistincion3.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void CargarAlumnos()
        {

            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
            {
                MessageBox.Show("El archivo no existe.");
            }
            else
            {
                StreamReader sr = fi.OpenText();

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    
                        string[] vector = linea.Split('-');
                        Alumno alumno = new Alumno();

                        alumno.NroRegistro = Convert.ToInt32(vector[0]);
                        alumno.Nombre = vector[1];
                        alumno.Apellido = vector[2];
                        alumno.MateriasAprobadas = Convert.ToByte(vector[3]);
                        alumno.MateriasAprobadas = Convert.ToByte(vector[4]);
                        alumno.Promedio = Convert.ToSingle(vector[5]);

                        alumnos.Add(alumno);
                        ListaAlumnos.Items.Add(alumno.NroRegistro + "-" + alumno.Nombre + "-" + alumno.Apellido + "-" + alumno.MateriasAprobadas
                            + "-" + alumno.MateriasRestantes + "-" + alumno.Promedio);
                    
                }

                sr.Close();
                MessageBox.Show("Se cargó el archivo: " + path, "Bienvenido");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileInfo fi = new FileInfo(path);

            StreamWriter sw = new StreamWriter(path);

            foreach (Alumno alumno in alumnos)
            {
                sw.WriteLine(alumno.NroRegistro + "-" + alumno.Nombre + "-" + alumno.Apellido + "-" + alumno.MateriasAprobadas
                        + "-" + alumno.MateriasRestantes + "-" + alumno.Promedio);
            }

            sw.Close();
            MessageBox.Show("Hasta Luego!" + System.Environment.NewLine + "Se guardó correctamente el archivo.");

        }
    }
}
