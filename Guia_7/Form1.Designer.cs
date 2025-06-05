namespace Guia_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpboxAlumnos = new GroupBox();
            btnEliminarAlumno = new Button();
            btnMostrarDatos = new Button();
            label1 = new Label();
            ListaAlumnos = new ListBox();
            btnAgregarAlumno = new Button();
            txtMatRes = new TextBox();
            lblMatRes = new Label();
            txtPromedio = new TextBox();
            lblPromedio = new Label();
            txtApellido = new TextBox();
            lblNombre = new Label();
            txtMatAp = new TextBox();
            lblMatAp = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtNroRegistro = new TextBox();
            lblNroRegistro = new Label();
            groupBox1 = new GroupBox();
            btnBuscarAlumno = new Button();
            lblNroRegistroBuscar = new Label();
            txtRegistroBuscar = new TextBox();
            gbDistinciones = new GroupBox();
            btnMostrarDistinciones = new Button();
            rbDistincion3 = new RadioButton();
            rbDistincion2 = new RadioButton();
            rbDistincion1 = new RadioButton();
            grpboxAlumnos.SuspendLayout();
            groupBox1.SuspendLayout();
            gbDistinciones.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxAlumnos
            // 
            grpboxAlumnos.Controls.Add(btnEliminarAlumno);
            grpboxAlumnos.Controls.Add(btnMostrarDatos);
            grpboxAlumnos.Controls.Add(label1);
            grpboxAlumnos.Controls.Add(ListaAlumnos);
            grpboxAlumnos.Controls.Add(btnAgregarAlumno);
            grpboxAlumnos.Controls.Add(txtMatRes);
            grpboxAlumnos.Controls.Add(lblMatRes);
            grpboxAlumnos.Controls.Add(txtPromedio);
            grpboxAlumnos.Controls.Add(lblPromedio);
            grpboxAlumnos.Controls.Add(txtApellido);
            grpboxAlumnos.Controls.Add(lblNombre);
            grpboxAlumnos.Controls.Add(txtMatAp);
            grpboxAlumnos.Controls.Add(lblMatAp);
            grpboxAlumnos.Controls.Add(txtNombre);
            grpboxAlumnos.Controls.Add(lblApellido);
            grpboxAlumnos.Controls.Add(txtNroRegistro);
            grpboxAlumnos.Controls.Add(lblNroRegistro);
            grpboxAlumnos.Location = new Point(27, 19);
            grpboxAlumnos.Name = "grpboxAlumnos";
            grpboxAlumnos.Size = new Size(1211, 372);
            grpboxAlumnos.TabIndex = 0;
            grpboxAlumnos.TabStop = false;
            grpboxAlumnos.Text = "Alumnos";
            // 
            // btnEliminarAlumno
            // 
            btnEliminarAlumno.Location = new Point(405, 336);
            btnEliminarAlumno.Name = "btnEliminarAlumno";
            btnEliminarAlumno.Size = new Size(145, 30);
            btnEliminarAlumno.TabIndex = 16;
            btnEliminarAlumno.Text = "Eliminar alumno";
            btnEliminarAlumno.UseVisualStyleBackColor = true;
            btnEliminarAlumno.Click += btnEliminarAlumno_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(215, 298);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(141, 32);
            btnMostrarDatos.TabIndex = 15;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 23);
            label1.Name = "label1";
            label1.Size = new Size(521, 20);
            label1.TabIndex = 14;
            label1.Text = "Registro-Nombre-Apellido-MateriasAprobadas-MateriasRestantes-Promedio";
            // 
            // ListaAlumnos
            // 
            ListaAlumnos.FormattingEnabled = true;
            ListaAlumnos.Location = new Point(405, 46);
            ListaAlumnos.Name = "ListaAlumnos";
            ListaAlumnos.Size = new Size(800, 284);
            ListaAlumnos.TabIndex = 13;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(51, 298);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(135, 32);
            btnAgregarAlumno.TabIndex = 12;
            btnAgregarAlumno.Text = "Agregar alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            btnAgregarAlumno.Click += btnAgregarAlumno_Click;
            // 
            // txtMatRes
            // 
            txtMatRes.Location = new Point(26, 244);
            txtMatRes.Name = "txtMatRes";
            txtMatRes.Size = new Size(160, 27);
            txtMatRes.TabIndex = 11;
            // 
            // lblMatRes
            // 
            lblMatRes.AutoSize = true;
            lblMatRes.Location = new Point(26, 221);
            lblMatRes.Name = "lblMatRes";
            lblMatRes.Size = new Size(129, 20);
            lblMatRes.TabIndex = 10;
            lblMatRes.Text = "Materias restantes";
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(215, 244);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(167, 27);
            txtPromedio.TabIndex = 9;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(216, 221);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(74, 20);
            lblPromedio.TabIndex = 8;
            lblPromedio.Text = "Promedio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(26, 154);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 27);
            txtApellido.TabIndex = 7;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(216, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtMatAp
            // 
            txtMatAp.Location = new Point(215, 154);
            txtMatAp.Name = "txtMatAp";
            txtMatAp.Size = new Size(167, 27);
            txtMatAp.TabIndex = 5;
            // 
            // lblMatAp
            // 
            lblMatAp.AutoSize = true;
            lblMatAp.Location = new Point(216, 131);
            lblMatAp.Name = "lblMatAp";
            lblMatAp.Size = new Size(141, 20);
            lblMatAp.TabIndex = 4;
            lblMatAp.Text = "Materias aprobadas";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(215, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(167, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(26, 131);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNroRegistro
            // 
            txtNroRegistro.Location = new Point(26, 66);
            txtNroRegistro.Name = "txtNroRegistro";
            txtNroRegistro.Size = new Size(160, 27);
            txtNroRegistro.TabIndex = 1;
            // 
            // lblNroRegistro
            // 
            lblNroRegistro.AutoSize = true;
            lblNroRegistro.Location = new Point(26, 43);
            lblNroRegistro.Name = "lblNroRegistro";
            lblNroRegistro.Size = new Size(92, 20);
            lblNroRegistro.TabIndex = 0;
            lblNroRegistro.Text = "Nro. registro";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarAlumno);
            groupBox1.Controls.Add(lblNroRegistroBuscar);
            groupBox1.Controls.Add(txtRegistroBuscar);
            groupBox1.Location = new Point(32, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 144);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar";
            // 
            // btnBuscarAlumno
            // 
            btnBuscarAlumno.Location = new Point(75, 90);
            btnBuscarAlumno.Name = "btnBuscarAlumno";
            btnBuscarAlumno.Size = new Size(115, 35);
            btnBuscarAlumno.TabIndex = 2;
            btnBuscarAlumno.Text = "Buscar";
            btnBuscarAlumno.UseVisualStyleBackColor = true;
            btnBuscarAlumno.Click += btnBuscarAlumno_Click;
            // 
            // lblNroRegistroBuscar
            // 
            lblNroRegistroBuscar.AutoSize = true;
            lblNroRegistroBuscar.Location = new Point(21, 34);
            lblNroRegistroBuscar.Name = "lblNroRegistroBuscar";
            lblNroRegistroBuscar.Size = new Size(92, 20);
            lblNroRegistroBuscar.TabIndex = 1;
            lblNroRegistroBuscar.Text = "Nro. registro";
            // 
            // txtRegistroBuscar
            // 
            txtRegistroBuscar.Location = new Point(21, 57);
            txtRegistroBuscar.Name = "txtRegistroBuscar";
            txtRegistroBuscar.Size = new Size(230, 27);
            txtRegistroBuscar.TabIndex = 0;
            // 
            // gbDistinciones
            // 
            gbDistinciones.Controls.Add(btnMostrarDistinciones);
            gbDistinciones.Controls.Add(rbDistincion3);
            gbDistinciones.Controls.Add(rbDistincion2);
            gbDistinciones.Controls.Add(rbDistincion1);
            gbDistinciones.Location = new Point(333, 408);
            gbDistinciones.Name = "gbDistinciones";
            gbDistinciones.Size = new Size(149, 180);
            gbDistinciones.TabIndex = 2;
            gbDistinciones.TabStop = false;
            gbDistinciones.Text = "Distinciones";
            // 
            // btnMostrarDistinciones
            // 
            btnMostrarDistinciones.Location = new Point(26, 134);
            btnMostrarDistinciones.Name = "btnMostrarDistinciones";
            btnMostrarDistinciones.Size = new Size(97, 30);
            btnMostrarDistinciones.TabIndex = 3;
            btnMostrarDistinciones.Text = "Mostrar";
            btnMostrarDistinciones.UseVisualStyleBackColor = true;
            btnMostrarDistinciones.Click += btnMostrarDistinciones_Click;
            // 
            // rbDistincion3
            // 
            rbDistincion3.AutoSize = true;
            rbDistincion3.Location = new Point(15, 90);
            rbDistincion3.Name = "rbDistincion3";
            rbDistincion3.Size = new Size(108, 24);
            rbDistincion3.TabIndex = 2;
            rbDistincion3.TabStop = true;
            rbDistincion3.Text = "Distincion 3";
            rbDistincion3.UseVisualStyleBackColor = true;
            // 
            // rbDistincion2
            // 
            rbDistincion2.AutoSize = true;
            rbDistincion2.Location = new Point(15, 60);
            rbDistincion2.Name = "rbDistincion2";
            rbDistincion2.Size = new Size(108, 24);
            rbDistincion2.TabIndex = 1;
            rbDistincion2.TabStop = true;
            rbDistincion2.Text = "Distincion 2";
            rbDistincion2.UseVisualStyleBackColor = true;
            // 
            // rbDistincion1
            // 
            rbDistincion1.AutoSize = true;
            rbDistincion1.Location = new Point(15, 30);
            rbDistincion1.Name = "rbDistincion1";
            rbDistincion1.Size = new Size(108, 24);
            rbDistincion1.TabIndex = 0;
            rbDistincion1.TabStop = true;
            rbDistincion1.Text = "Distincion 1";
            rbDistincion1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 729);
            Controls.Add(gbDistinciones);
            Controls.Add(groupBox1);
            Controls.Add(grpboxAlumnos);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            grpboxAlumnos.ResumeLayout(false);
            grpboxAlumnos.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbDistinciones.ResumeLayout(false);
            gbDistinciones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxAlumnos;
        private TextBox txtNroRegistro;
        private Label lblNroRegistro;
        private TextBox txtPromedio;
        private Label lblPromedio;
        private TextBox txtApellido;
        private Label lblNombre;
        private TextBox txtMatAp;
        private Label lblMatAp;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtMatRes;
        private Label lblMatRes;
        private Button btnAgregarAlumno;
        private ListBox ListaAlumnos;
        private Label label1;
        private Button btnMostrarDatos;
        private GroupBox groupBox1;
        private Button btnBuscarAlumno;
        private Label lblNroRegistroBuscar;
        private TextBox txtRegistroBuscar;
        private Button btnEliminarAlumno;
        private GroupBox gbDistinciones;
        private RadioButton rbDistincion3;
        private RadioButton rbDistincion2;
        private RadioButton rbDistincion1;
        private Button btnMostrarDistinciones;
    }
}
