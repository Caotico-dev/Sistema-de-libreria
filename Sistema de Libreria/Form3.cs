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
    public partial class FormUsuario : Form
    {
        private readonly formUsuarioPrestamos formUsuarioPrestamos;
        private readonly BibliotecaContext BibliotecaContext;

        public FormUsuario(formUsuarioPrestamos formUsuarioPrestamos, BibliotecaContext bibliotecaContext)
        {
            InitializeComponent();
            this.formUsuarioPrestamos = formUsuarioPrestamos;
            this.BibliotecaContext = bibliotecaContext;
        }

        private void FormUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            formUsuarioPrestamos.Show();
        }
        private void RegistrarUsuario()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_nombre.Text) && !string.IsNullOrWhiteSpace(Box_Correo.Text) && !string.IsNullOrWhiteSpace(Box_telefono.Text) && !string.IsNullOrWhiteSpace(Box_direccion.Text))
                {
                    var usuario = new Usuario { Nombre = Box_nombre.Text, CorreoElectronico = Box_Correo.Text, Telefono = Box_telefono.Text, Direccion = Box_direccion.Text };
                    this.BibliotecaContext.Usuarios.Add(usuario);
                    this.BibliotecaContext.SaveChanges();
                    MessageBox.Show("Usuario registrado con exito!.");
                }
                else
                {
                    MessageBox.Show("Recuerda rellenar todos los campos.");
                }
            }
            catch
            {
                MessageBox.Show("Recuerda rellenar todos los campos correctamente.");
            }
            Box_nombre.Text = null;
            Box_Correo.Text = null;
            Box_direccion.Text = null;
            Box_telefono.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarUsuario();
        }
    }
}
