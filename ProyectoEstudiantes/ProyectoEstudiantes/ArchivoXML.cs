using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace ProyectoEstudiantes
{
    public static class ArchivoXML
    {
        // Método para guardar una lista de estudiantes en un archivo XML
        public static void GuardarEstudiantes(List<Estudiante> estudiantes, string rutaArchivo)
        {
            if (estudiantes == null)
                throw new ArgumentNullException(nameof(estudiantes), "La lista de estudiantes no puede ser nula.");
            if (string.IsNullOrWhiteSpace(rutaArchivo))
                throw new ArgumentException("La ruta del archivo no puede ser nula o vacía.", nameof(rutaArchivo));

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Estudiante>));
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    serializer.Serialize(fs, estudiantes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        // Método para leer los estudiantes desde un archivo XML
        public static List<Estudiante> LeerEstudiantes(string rutaArchivo)
        {
            if (string.IsNullOrWhiteSpace(rutaArchivo))
                throw new ArgumentException("La ruta del archivo no puede ser nula o vacía.", nameof(rutaArchivo));

            try
            {
                if (!File.Exists(rutaArchivo))
                    return new List<Estudiante>();

                XmlSerializer serializer = new XmlSerializer(typeof(List<Estudiante>));
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                {
                    var estudiantes = serializer.Deserialize(fs) as List<Estudiante>;
                    return estudiantes ?? new List<Estudiante>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
                return new List<Estudiante>();
            }
        }
    }
}



