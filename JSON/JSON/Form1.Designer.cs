namespace JSON
{
    partial class Form_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Productos));
            this.gb_Titulo = new System.Windows.Forms.GroupBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.gb_Info = new System.Windows.Forms.GroupBox();
            this.btn_Leer = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.gb_Productos = new System.Windows.Forms.GroupBox();
            this.list_Productos = new System.Windows.Forms.ListBox();
            this.gb_Titulo.SuspendLayout();
            this.gb_Info.SuspendLayout();
            this.gb_Productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Titulo
            // 
            this.gb_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(171)))));
            this.gb_Titulo.Controls.Add(this.lbl_Titulo);
            this.gb_Titulo.Location = new System.Drawing.Point(11, 17);
            this.gb_Titulo.Name = "gb_Titulo";
            this.gb_Titulo.Size = new System.Drawing.Size(777, 61);
            this.gb_Titulo.TabIndex = 0;
            this.gb_Titulo.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Curlz MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Titulo.Location = new System.Drawing.Point(233, 7);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(311, 45);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Productos Navideños";
            // 
            // gb_Info
            // 
            this.gb_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.gb_Info.Controls.Add(this.btn_Leer);
            this.gb_Info.Controls.Add(this.btn_Eliminar);
            this.gb_Info.Controls.Add(this.btn_Guardar);
            this.gb_Info.Controls.Add(this.btn_Agregar);
            this.gb_Info.Controls.Add(this.txt_Precio);
            this.gb_Info.Controls.Add(this.txt_Nombre);
            this.gb_Info.Controls.Add(this.txt_ID);
            this.gb_Info.Controls.Add(this.lbl_Precio);
            this.gb_Info.Controls.Add(this.lbl_Nombre);
            this.gb_Info.Controls.Add(this.lbl_ID);
            this.gb_Info.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_Info.Location = new System.Drawing.Point(17, 94);
            this.gb_Info.Name = "gb_Info";
            this.gb_Info.Size = new System.Drawing.Size(268, 324);
            this.gb_Info.TabIndex = 1;
            this.gb_Info.TabStop = false;
            this.gb_Info.Text = "Información";
            // 
            // btn_Leer
            // 
            this.btn_Leer.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Leer.Location = new System.Drawing.Point(146, 262);
            this.btn_Leer.Name = "btn_Leer";
            this.btn_Leer.Size = new System.Drawing.Size(94, 29);
            this.btn_Leer.TabIndex = 8;
            this.btn_Leer.Text = "Leer";
            this.btn_Leer.UseVisualStyleBackColor = true;
            this.btn_Leer.Click += new System.EventHandler(this.btn_Leer_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.Location = new System.Drawing.Point(35, 262);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 29);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.Location = new System.Drawing.Point(146, 214);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(94, 29);
            this.btn_Guardar.TabIndex = 8;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(35, 214);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(94, 29);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Precio
            // 
            this.txt_Precio.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Precio.Location = new System.Drawing.Point(127, 154);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(125, 31);
            this.txt_Precio.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nombre.Location = new System.Drawing.Point(127, 100);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(125, 31);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ID.Location = new System.Drawing.Point(127, 51);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(125, 31);
            this.txt_ID.TabIndex = 4;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.Location = new System.Drawing.Point(40, 159);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(60, 20);
            this.lbl_Precio.TabIndex = 3;
            this.lbl_Precio.Text = "Precio:";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(40, 105);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(75, 20);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ID.Location = new System.Drawing.Point(40, 65);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(34, 20);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID:";
            this.lbl_ID.Click += new System.EventHandler(this.lbl_ID_Click);
            // 
            // gb_Productos
            // 
            this.gb_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.gb_Productos.Controls.Add(this.list_Productos);
            this.gb_Productos.Font = new System.Drawing.Font("Pristina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_Productos.Location = new System.Drawing.Point(291, 100);
            this.gb_Productos.Name = "gb_Productos";
            this.gb_Productos.Size = new System.Drawing.Size(474, 318);
            this.gb_Productos.TabIndex = 2;
            this.gb_Productos.TabStop = false;
            this.gb_Productos.Text = "Productos";
            // 
            // list_Productos
            // 
            this.list_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Productos.Font = new System.Drawing.Font("PMingLiU-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_Productos.FormattingEnabled = true;
            this.list_Productos.ItemHeight = 20;
            this.list_Productos.Location = new System.Drawing.Point(22, 37);
            this.list_Productos.Name = "list_Productos";
            this.list_Productos.Size = new System.Drawing.Size(425, 264);
            this.list_Productos.TabIndex = 0;
            // 
            // Form_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_Productos);
            this.Controls.Add(this.gb_Info);
            this.Controls.Add(this.gb_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Productos";
            this.Text = "Productos Navideños";
            this.gb_Titulo.ResumeLayout(false);
            this.gb_Titulo.PerformLayout();
            this.gb_Info.ResumeLayout(false);
            this.gb_Info.PerformLayout();
            this.gb_Productos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_Titulo;
        private Label lbl_Titulo;
        private GroupBox gb_Info;
        private GroupBox gb_Productos;
        private Label lbl_Precio;
        private Label lbl_Nombre;
        private Label lbl_ID;
        private Button btn_Leer;
        private Button btn_Eliminar;
        private Button btn_Guardar;
        private Button btn_Agregar;
        private TextBox txt_Precio;
        private TextBox txt_Nombre;
        private TextBox txt_ID;
        private ListBox list_Productos;
    }
}