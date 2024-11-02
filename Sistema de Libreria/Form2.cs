using Microsoft.EntityFrameworkCore;
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
    public partial class formUsuarioPrestamos : Form
    {
        private readonly FormInico FormInico;

        private readonly BibliotecaContext BibliotecaContext;
        public formUsuarioPrestamos(FormInico formInico, BibliotecaContext bibliotecaContext)
        {
            InitializeComponent();
            FormInico = formInico;
            this.BibliotecaContext = bibliotecaContext;


        }
        private void formUsuarioPrestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Restaurar();
            Thread.Sleep(1000);
            FormInico.Show();//mostrar
        }

        private void formUsuarioPrestamos_Load(object sender, EventArgs e)
        {
            this.BibliotecaContext.Usuarios.Load();
            this.BibliotecaContext.Prestamos.Load();

            usuarioBindingSource.DataSource = this.BibliotecaContext.Usuarios.Local.ToBindingList();
            prestamosBindingSource.DataSource = this.BibliotecaContext.Prestamos.Local.ToBindingList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario(this, this.BibliotecaContext);
            formUsuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrestamos formPrestamos = new FormPrestamos(this, this.BibliotecaContext);
            formPrestamos.Show();
            this.Hide();
        }
        private void EliminarPrestamo()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_Prestamo.Text))
                {
                    int prestamo = int.Parse(Box_Prestamo.Text);
                    var busqueda = this.BibliotecaContext.Prestamos.Find(prestamo);

                    if (busqueda != null)
                    {
                        this.BibliotecaContext.Prestamos.Remove(busqueda);
                        this.BibliotecaContext.SaveChanges();
                        dataGridViewPrestamo.Refresh();
                        MessageBox.Show("Prestamo borrado exitosamente!.");
                    }
                    else
                    {
                        MessageBox.Show($"Libro id {prestamo} no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Recuerda rellenar el campo.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar los campos correctamente.");
            }
            Box_Prestamo.Text = null;
        }
        private void EliminarUsuario()
        {

            try
            {
                if (!string.IsNullOrWhiteSpace(Box_Usuario.ToString()))
                {
                    int usuario = int.Parse(Box_Usuario.Text);
                    var busqueda = this.BibliotecaContext.Usuarios.Find(usuario);

                    if (busqueda != null)
                    {
                        this.BibliotecaContext.Usuarios.Remove(busqueda);
                        this.BibliotecaContext.SaveChanges();
                        dataGridViewUsuario.Refresh();
                        MessageBox.Show("Usuario borrado exitosamente!.");
                    }
                    else
                    {
                        MessageBox.Show($"Libro id {usuario} no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Recuerda rellenar el campo.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar los campos correctamente.");
            }
            Box_Usuario.Text = null;

        }

        private void BuscarPrestamos()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_Prestamo.Text))
                {
                    var prestamos = this.BibliotecaContext.Prestamos.FirstOrDefault(p => p.UsuarioId.ToString() == Box_Prestamo.ToString());
                    if (prestamos != null)
                    {
                        prestamosBindingSource.DataSource = prestamos;
                        MessageBox.Show("Prestamo encontrado, Recuerda reiniciar la pestaña para actualizar los registro.");
                    }
                    else
                    {
                        MessageBox.Show("Prestamo no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Recuerda rellenar el campo.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar el campo correctamente.");
            }
            Box_Prestamo.Text = string.Empty;
        }
        private void BuscarUsuario()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_Usuario.Text))
                {
                    var usuario = this.BibliotecaContext.Usuarios.FirstOrDefault(u => u.Nombre!.ToLower() == Box_Usuario.Text.ToLower());
                    if (usuario != null)
                    {
                        usuarioBindingSource.DataSource = usuario;
                        MessageBox.Show("Usuario encontrado, Recuerda reiniciar la pestaña para actualizar los registro.");
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Recuerda rellenar el campo.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar el campo correctamente.");
            }
            Box_Usuario.Text = string.Empty;
        }
        private void Restaurar()
        {
            try
            {
                var libro = this.BibliotecaContext.Prestamos.Where(d => d.Devuelto == true && d.Procesado == false).ToList();

                foreach (var item in libro)
                {
                    var buscar = this.BibliotecaContext.Libros.Find(item.LibroId);
                    if (buscar != null)
                    {
                        buscar!.Stock = buscar.Stock + 1;
                    }
                    item.Procesado = true;

                }
                this.BibliotecaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuscarPrestamos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarPrestamo();
        }
    }
}
