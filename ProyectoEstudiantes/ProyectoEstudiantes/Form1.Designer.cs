namespace ProyectoEstudiantes
{
    partial class Form_Gestion
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnVerDatos;
        private Button btnSalir;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCarnet;
        private TextBox txtCarrera;
        private ComboBox comboBoxMateria;
        private ListBox ListaEstudiantes;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gestion));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.ListaEstudiantes = new System.Windows.Forms.ListBox();
            this.gb_Titulo = new System.Windows.Forms.GroupBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Materias = new System.Windows.Forms.Label();
            this.lbl_Carrera = new System.Windows.Forms.Label();
            this.lbl_Carnet = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.gb_ListaEstudiante = new System.Windows.Forms.GroupBox();
            this.gb_Botones = new System.Windows.Forms.GroupBox();
            this.gb_Titulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_ListaEstudiante.SuspendLayout();
            this.gb_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(36, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(243, 10);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.BackColor = System.Drawing.Color.White;
            this.btnVerDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerDatos.Location = new System.Drawing.Point(442, 10);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(100, 30);
            this.btnVerDatos.TabIndex = 2;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = false;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(667, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(117, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 29);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.Location = new System.Drawing.Point(117, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(169, 29);
            this.txtApellido.TabIndex = 6;
            // 
            // txtCarnet
            // 
            this.txtCarnet.BackColor = System.Drawing.Color.White;
            this.txtCarnet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCarnet.Location = new System.Drawing.Point(117, 119);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(169, 29);
            this.txtCarnet.TabIndex = 7;
            // 
            // txtCarrera
            // 
            this.txtCarrera.BackColor = System.Drawing.Color.White;
            this.txtCarrera.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCarrera.Location = new System.Drawing.Point(117, 162);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(169, 29);
            this.txtCarrera.TabIndex = 8;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.BackColor = System.Drawing.Color.White;
            this.comboBoxMateria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMateria.Items.AddRange(new object[] {
            "Matemáticas",
            "Programación",
            "Inglés",
            "Contabilidad de Costos",
            "Sociología"});
            this.comboBoxMateria.Location = new System.Drawing.Point(117, 200);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(169, 29);
            this.comboBoxMateria.TabIndex = 9;
            // 
            // ListaEstudiantes
            // 
            this.ListaEstudiantes.BackColor = System.Drawing.Color.White;
            this.ListaEstudiantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListaEstudiantes.FormattingEnabled = true;
            this.ListaEstudiantes.ItemHeight = 20;
            this.ListaEstudiantes.Location = new System.Drawing.Point(15, 25);
            this.ListaEstudiantes.Name = "ListaEstudiantes";
            this.ListaEstudiantes.Size = new System.Drawing.Size(446, 224);
            this.ListaEstudiantes.TabIndex = 10;
            this.ListaEstudiantes.SelectedIndexChanged += new System.EventHandler(this.ListaEstudiantes_SelectedIndexChanged);
            // 
            // gb_Titulo
            // 
            this.gb_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.gb_Titulo.Controls.Add(this.lbl_Titulo);
            this.gb_Titulo.Location = new System.Drawing.Point(17, 12);
            this.gb_Titulo.Name = "gb_Titulo";
            this.gb_Titulo.Size = new System.Drawing.Size(801, 53);
            this.gb_Titulo.TabIndex = 11;
            this.gb_Titulo.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("PMingLiU-ExtB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(232, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(274, 28);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Gestión de Estudiantes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(199)))), ((int)(((byte)(250)))));
            this.groupBox1.Controls.Add(this.lbl_Materias);
            this.groupBox1.Controls.Add(this.lbl_Carrera);
            this.groupBox1.Controls.Add(this.lbl_Carnet);
            this.groupBox1.Controls.Add(this.lbl_Apellido);
            this.groupBox1.Controls.Add(this.lbl_Nombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.comboBoxMateria);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.txtCarrera);
            this.groupBox1.Location = new System.Drawing.Point(31, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 264);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infomación";
            // 
            // lbl_Materias
            // 
            this.lbl_Materias.AutoSize = true;
            this.lbl_Materias.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Materias.Location = new System.Drawing.Point(15, 204);
            this.lbl_Materias.Name = "lbl_Materias";
            this.lbl_Materias.Size = new System.Drawing.Size(89, 19);
            this.lbl_Materias.TabIndex = 13;
            this.lbl_Materias.Text = "Materias";
            // 
            // lbl_Carrera
            // 
            this.lbl_Carrera.AutoSize = true;
            this.lbl_Carrera.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Carrera.Location = new System.Drawing.Point(15, 166);
            this.lbl_Carrera.Name = "lbl_Carrera";
            this.lbl_Carrera.Size = new System.Drawing.Size(89, 19);
            this.lbl_Carrera.TabIndex = 13;
            this.lbl_Carrera.Text = "Carrera:";
            // 
            // lbl_Carnet
            // 
            this.lbl_Carnet.AutoSize = true;
            this.lbl_Carnet.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Carnet.Location = new System.Drawing.Point(11, 123);
            this.lbl_Carnet.Name = "lbl_Carnet";
            this.lbl_Carnet.Size = new System.Drawing.Size(79, 19);
            this.lbl_Carnet.TabIndex = 13;
            this.lbl_Carnet.Text = "Carnet:";
            this.lbl_Carnet.Click += new System.EventHandler(this.lbl_Carnet_Click);
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellido.Location = new System.Drawing.Point(11, 81);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(99, 19);
            this.lbl_Apellido.TabIndex = 10;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(11, 41);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(79, 19);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre:";
            this.lbl_Nombre.Click += new System.EventHandler(this.lbl_Nombre_Click);
            // 
            // gb_ListaEstudiante
            // 
            this.gb_ListaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(253)))), ((int)(((byte)(210)))));
            this.gb_ListaEstudiante.Controls.Add(this.ListaEstudiantes);
            this.gb_ListaEstudiante.Location = new System.Drawing.Point(348, 87);
            this.gb_ListaEstudiante.Name = "gb_ListaEstudiante";
            this.gb_ListaEstudiante.Size = new System.Drawing.Size(480, 259);
            this.gb_ListaEstudiante.TabIndex = 13;
            this.gb_ListaEstudiante.TabStop = false;
            this.gb_ListaEstudiante.Text = "Lista de Estudiantes";
            // 
            // gb_Botones
            // 
            this.gb_Botones.Controls.Add(this.btnSalir);
            this.gb_Botones.Controls.Add(this.btnAgregar);
            this.gb_Botones.Controls.Add(this.btnVerDatos);
            this.gb_Botones.Controls.Add(this.btnGuardar);
            this.gb_Botones.Location = new System.Drawing.Point(17, 355);
            this.gb_Botones.Name = "gb_Botones";
            this.gb_Botones.Size = new System.Drawing.Size(811, 58);
            this.gb_Botones.TabIndex = 14;
            this.gb_Botones.TabStop = false;
            // 
            // Form_Gestion
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(240)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(853, 422);
            this.Controls.Add(this.gb_Botones);
            this.Controls.Add(this.gb_ListaEstudiante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Titulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Gestion";
            this.Text = "Gestion de Estudiantes";
            this.gb_Titulo.ResumeLayout(false);
            this.gb_Titulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_ListaEstudiante.ResumeLayout(false);
            this.gb_Botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private GroupBox gb_Titulo;
        private Label lbl_Titulo;
        private GroupBox groupBox1;
        private Label lbl_Nombre;
        private Label lbl_Carnet;
        private Label lbl_Apellido;
        private Label lbl_Materias;
        private Label lbl_Carrera;
        private GroupBox gb_ListaEstudiante;
        private GroupBox gb_Botones;
    }
}