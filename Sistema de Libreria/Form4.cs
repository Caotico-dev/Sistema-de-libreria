using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Libreria
{
    public partial class FormPrestamos : Form
    {
        private  readonly formUsuarioPrestamos formUsuarioPrestamos;
        private  readonly BibliotecaContext BibliotecaContext;
        public FormPrestamos(formUsuarioPrestamos formUsuarioPrestamos, BibliotecaContext bibliotecaContext)
        {
            InitializeComponent();
            this.formUsuarioPrestamos = formUsuarioPrestamos;
            this.BibliotecaContext = bibliotecaContext;
        }

        private void FormPrestamos_FormClosing(object sender, FormClosingEventArgs e)
        {            
            formUsuarioPrestamos.Show();
        }       
        private void Prestamo()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_UsuarioId.Text) && !string.IsNullOrWhiteSpace(Box_LibroId.Text))
                {
                    int UsuarioId = int.Parse(Box_UsuarioId.Text);
                    var usuario = this.BibliotecaContext.Usuarios.Find(UsuarioId); 
                    if (usuario == null)
                    {
                        MessageBox.Show($"Usuario id {UsuarioId} no encontrado.");
                        Box_UsuarioId.Text = string.Empty;
                        return;
                    }

                    int libroid = int.Parse(Box_LibroId.Text);
                    var libro = this.BibliotecaContext.Libros.Find(libroid);    
                    if (libro == null)
                    {
                        MessageBox.Show($"Libro id {libroid} no encontrado.");
                        Box_LibroId.Text = string.Empty;
                        return;
                    }                    

                    if (dateTimePicker1.Value <= DateTime.Now)
                    {
                        MessageBox.Show("La fecha tiene que ser mayor a la actual.");
                        dateTimePicker1.ResetText();
                        return;
                    }                  


                    var prestamo = new Prestamos { UsuarioId = UsuarioId, LibroId = libroid, FechaPrestamo = DateTime.Now.Date, FechaDevolucion = dateTimePicker1.Value, Devuelto = false, Procesado = false };
                    this.BibliotecaContext.Prestamos.Add(prestamo);
                                        
                    
                    libro!.Stock = libro.Stock - 1;

                    this.BibliotecaContext.SaveChanges();
                    MessageBox.Show("Prestamo realizado con exito.");

                }
                else
                {
                    MessageBox.Show("Recuerda rellenar todos los campos ");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente.");
            }

            //Limpiar
            Box_UsuarioId.Text = string.Empty;
            Box_LibroId.Text = string.Empty;
            dateTimePicker1.ResetText();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prestamo();
        }
    }
}
