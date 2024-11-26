using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace JSON
{
    public partial class Form_Productos : Form
    {
        private List<Productos> listproducto = new List<Productos>();
        private const string Ruta = "Productos.json";

        private void MostrarProductos()
        {
            list_Productos.Items.Clear();
            foreach (var producto in listproducto)
            {
                list_Productos.Items.Add($"ID: {producto.ID}, Nombre: {producto.Nombre}, Precio: {producto.Precio:C}, Cantidad: {producto.Cantidad}");
            }
        }
        private void LimpiarCampos()
        {
            txt_ID.Clear();
            txt_Nombre.Clear();
            txt_Precio.Clear();
            txt_Cantidad.Clear();
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
                    Precio = decimal.Parse(txt_Precio.Text),
                    Cantidad = int.Parse(txt_Cantidad.Text)
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
                File.WriteAllText(Ruta, jsonData);
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
                if (File.Exists(Ruta))
                {
                    string jsonData = File.ReadAllText(Ruta);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}