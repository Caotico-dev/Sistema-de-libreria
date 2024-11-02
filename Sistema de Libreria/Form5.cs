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

    public partial class FormLibro : Form
    {
        private readonly FormInico FormInico;
        private readonly BibliotecaContext BibliotecaContext;

        public FormLibro(FormInico formInico, BibliotecaContext bibliotecaContext)
        {
            InitializeComponent();
            FormInico = formInico;
            this.BibliotecaContext = bibliotecaContext;

        }
        private void Registrar()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_titulo.Text) && !string.IsNullOrWhiteSpace(Box_autor.Text) && !string.IsNullOrWhiteSpace(Box_genero.Text) && !string.IsNullOrWhiteSpace(Box_año.Text) && !string.IsNullOrWhiteSpace(Box_stock.Text) && !string.IsNullOrWhiteSpace(Box_cantida.Text))
                {
                    var libro = new Libros { Titulo = Box_titulo.Text, Autor = Box_autor.Text, Genero = Box_genero.Text, AñosPublicacion = int.Parse(Box_año.Text), Stock = int.Parse(Box_stock.Text), Cantidad = int.Parse(Box_cantida.Text)};
                    this.BibliotecaContext.Libros.Add(libro);
                    this.BibliotecaContext.SaveChanges(); 

                    MessageBox.Show("Libros guardados con exito!.");
                }
                else
                {
                    MessageBox.Show("Recuerda rellenar todos los campos correctamente");
                }              

            }
            catch
            {
                MessageBox.Show("Recuerda Rellanar los campos correctamente");
            }
            //Limpiar
            Box_titulo.Text = string.Empty;
            Box_autor.Text = string.Empty;
            Box_genero.Text = string.Empty;
            Box_año.Text = string.Empty;
            Box_stock.Text = string.Empty;
            Box_cantida.Text = string.Empty;    


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FormInico.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registrar();
        }
    }
}
