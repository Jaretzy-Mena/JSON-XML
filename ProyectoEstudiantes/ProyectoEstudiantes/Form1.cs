using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoEstudiantes
{
    public partial class Form_Gestion : Form
    {
        private List<Estudiante> estudiantes;
        private const string rutaArchivo = "archivo.xml"; // Ruta del archivo XML en el directorio del proyecto
        // @"c:\xml\archivo.xml"
        public Form_Gestion()
        {
            InitializeComponent();
            estudiantes = ArchivoXML.LeerEstudiantes(rutaArchivo) ?? new List<Estudiante>();
        }
       
        
        

        // Método para actualizar el ListBox con los estudiantes actuales
        private void ActualizarListaEstudiantes()
        {
            ListaEstudiantes.Items.Clear();
            foreach (var estudiante in estudiantes)
            {
                ListaEstudiantes.Items.Add($"Nombre: {estudiante.Nombre} {estudiante.Apellido}, Carrera: {estudiante.Carrera}, Materia: {estudiante.MateriaSeleccionada}");
            }
        }
        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Carnet_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCarnet.Text) ||
                string.IsNullOrWhiteSpace(txtCarrera.Text) ||
                comboBoxMateria.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string carnet = txtCarnet.Text;
            string carrera = txtCarrera.Text;
            string materiaSeleccionada = comboBoxMateria.SelectedItem?.ToString() ?? string.Empty;

            Estudiante nuevoEstudiante = new Estudiante
            {
                Nombre = $"{nombre}",
                Apellido = $"{apellido}",
                Carnet = $"{carnet}",
                Carrera = $"{carrera}",
                MateriaSeleccionada = $"{materiaSeleccionada}"
            };
            estudiantes.Add(nuevoEstudiante);
            MessageBox.Show("Estudiante añadido exitosamente.");
            LimpiarCampos();
            ActualizarListaEstudiantes();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            ArchivoXML.GuardarEstudiantes(estudiantes, rutaArchivo);
            MessageBox.Show("Datos guardados correctamente.");
        }

        private void btnVerDatos_Click_1(object sender, EventArgs e)
        {
            ActualizarListaEstudiantes();
        }

        // Método para limpiar los campos de texto
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCarnet.Clear();
            txtCarrera.Clear();
            comboBoxMateria.SelectedIndex = -1;
        }

        private void ListaEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }

}