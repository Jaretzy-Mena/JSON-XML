using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace JSON
{
    public partial class Form_Productos : Form
    {
        private List<Productos> listproducto = new List<Productos>();
        private const string FilePath = "Productos.json";

        private void MostrarProductos()
        {
            list_Productos.Items.Clear();
            foreach (var producto in listproducto)
            {
                list_Productos.Items.Add($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio:C}");
            }
        }
        private void LimpiarCampos()
        {
            txt_ID.Clear();
            txt_Nombre.Clear();
            txt_Precio.Clear();
        }
        public Form_Productos()
        {
            InitializeComponent();
        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Productos productos = new Productos
                {
                    ID = int.Parse(txt_ID.Text),
                    Nombre = txt_Nombre.Text,
                    Precio = decimal.Parse(txt_Precio.Text)
                };
                listproducto.Add(productos);
                MostrarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonData = System.Text.Json.JsonSerializer.Serialize(listproducto, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, jsonData);
                MessageBox.Show("Datos Guardados en JSON.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void btn_Leer_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string jsonData = File.ReadAllText(FilePath);
                    listproducto = System.Text.Json.JsonSerializer.Deserialize<List<Productos>>(jsonData) ?? new List<Productos>(); MostrarProductos();
                    MessageBox.Show("Datos cargados desde JSON.");
                }
                else
                {
                    MessageBox.Show("El archivo JSON no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (list_Productos.SelectedIndex != -1)
                {
                    int seleccionar = list_Productos.SelectedIndex;
                    listproducto.RemoveAt(seleccionar);
                    MostrarProductos();
                    MessageBox.Show("Producto eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un producto para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}