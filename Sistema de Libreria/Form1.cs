using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Libreria
{
    public partial class FormInico : Form
    {
        private BibliotecaContext BibliotecaContext;
        public FormInico()
        {
            InitializeComponent();
            BibliotecaContext = new BibliotecaContext();
            dataGridViewlibros.Refresh();
            Reporte();
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLibro formLibro = new(this, this.BibliotecaContext);
            formLibro.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.BibliotecaContext.Database.EnsureDeleted();
            //Crea la base de datos sino existe
            this.BibliotecaContext.Database.EnsureCreated();

            //Carga los datos
            this.BibliotecaContext.Libros.Load();
            //proyecta los datos
            librosBindingSource.DataSource = this.BibliotecaContext.Libros.Local.ToBindingList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            formUsuarioPrestamos formUsuarioPrestamos = new formUsuarioPrestamos(this, this.BibliotecaContext);
            //Mostrar
            formUsuarioPrestamos.Show();
            //Ocultar
            this.Hide();
        }

        private void FormInico_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.BibliotecaContext?.Dispose();
            this.BibliotecaContext = null;
        }
        private void Reporte()
        {
            var libros = this.BibliotecaContext.Libros.Where(a => a.Stock <= 10).Select(s => new { s.LibroId, s.Titulo }).ToList();
            LibroAgotado.Items.Clear();
            foreach (var libro in libros)
            {
                ListViewItem book = new ListViewItem(libro.LibroId.ToString()); 
                book.SubItems.Add(libro.Titulo);
                LibroAgotado.Items.Add(book);

            }
            var prestamos = this.BibliotecaContext.Prestamos.Where(f => f.FechaDevolucion <= DateTime.Now && f.Procesado == false ).Select(pre => new { pre.PrestamoId,pre.LibroId, pre.FechaDevolucion }).ToList();
            var LibroV = prestamos.Join(libros, pre => pre.LibroId, li => li.LibroId, (pre, li) => new { pre.PrestamoId, li.Titulo, pre.FechaDevolucion }).ToList();

            FechaVencida.Items.Clear();
            foreach (var libro in LibroV)
            {
                ListViewItem book = new(libro.PrestamoId.ToString());
                book.SubItems.Add(libro.Titulo);
                book.SubItems.Add(libro.FechaDevolucion.ToString());
                FechaVencida.Items.Add(book);
            }
        }

        private void BuscarLibro()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_libro.Text))
                {
                    var libro = this.BibliotecaContext.Libros.FirstOrDefault(l => l.Titulo!.ToLower() == Box_libro.Text.ToLower());
                    if (libro != null)
                    {
                        librosBindingSource.DataSource = libro;
                        MessageBox.Show("Libro encontrado.");
                        Actualizar.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Libro no encontrado.");
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
            Box_libro.Text = string.Empty;
        }
        private void Eliminar()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Box_libro.Text))
                {
                    int libro = int.Parse(Box_libro.Text);
                    var busqueda = this.BibliotecaContext.Libros.Find(libro);

                    if (busqueda != null)
                    {
                        this.BibliotecaContext.Libros.Remove(busqueda);
                        this.BibliotecaContext.SaveChanges();
                        dataGridViewlibros.Refresh();
                        MessageBox.Show("Libro borrado exitosamente!.");
                    }
                    else
                    {
                        MessageBox.Show($"Libro id {libro} no encontrado.");
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
            Box_libro.Text = string.Empty;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarLibro();
        }        

        private void Actualizar_Click(object sender, EventArgs e)
        {
            librosBindingSource.DataSource = this.BibliotecaContext.Libros.Local.ToBindingList();
            Actualizar.Visible = false;
        }
    }
}
