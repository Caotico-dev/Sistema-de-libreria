namespace Sistema_de_Libreria
{
    partial class formUsuarioPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuarioPrestamos));
            dataGridViewUsuario = new DataGridView();
            usuarioIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoElectronicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            direccionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewPrestamo = new DataGridView();
            prestamoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            libroIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaPrestamoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDevolucionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            devueltoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            procesadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            usuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            librosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prestamosBindingSource = new BindingSource(components);
            button3 = new Button();
            Box_Usuario = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            Box_Prestamo = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prestamosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsuario
            // 
            dataGridViewUsuario.AutoGenerateColumns = false;
            dataGridViewUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuario.Columns.AddRange(new DataGridViewColumn[] { usuarioIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, correoElectronicoDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, direccionDataGridViewTextBoxColumn });
            dataGridViewUsuario.DataSource = usuarioBindingSource;
            dataGridViewUsuario.Location = new Point(12, 77);
            dataGridViewUsuario.Name = "dataGridViewUsuario";
            dataGridViewUsuario.Size = new Size(672, 466);
            dataGridViewUsuario.TabIndex = 3;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "UsuarioId";
            usuarioIdDataGridViewTextBoxColumn.HeaderText = "ID";
            usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            usuarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            usuarioIdDataGridViewTextBoxColumn.Width = 53;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Width = 99;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            correoElectronicoDataGridViewTextBoxColumn.HeaderText = "CorreoElectronico";
            correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            correoElectronicoDataGridViewTextBoxColumn.Width = 176;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            telefonoDataGridViewTextBoxColumn.Width = 105;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            direccionDataGridViewTextBoxColumn.ReadOnly = true;
            direccionDataGridViewTextBoxColumn.Width = 109;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Usuario);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 4;
            label1.Text = "Sistema de control de libros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(741, 53);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 6;
            label3.Text = "Prestamos";
            // 
            // dataGridViewPrestamo
            // 
            dataGridViewPrestamo.AutoGenerateColumns = false;
            dataGridViewPrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPrestamo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPrestamo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrestamo.Columns.AddRange(new DataGridViewColumn[] { prestamoIdDataGridViewTextBoxColumn, usuarioIdDataGridViewTextBoxColumn1, libroIdDataGridViewTextBoxColumn, fechaPrestamoDataGridViewTextBoxColumn, fechaDevolucionDataGridViewTextBoxColumn, devueltoDataGridViewCheckBoxColumn, procesadoDataGridViewCheckBoxColumn, usuarioDataGridViewTextBoxColumn, librosDataGridViewTextBoxColumn });
            dataGridViewPrestamo.DataSource = prestamosBindingSource;
            dataGridViewPrestamo.Location = new Point(741, 77);
            dataGridViewPrestamo.Name = "dataGridViewPrestamo";
            dataGridViewPrestamo.Size = new Size(786, 466);
            dataGridViewPrestamo.TabIndex = 7;
            // 
            // prestamoIdDataGridViewTextBoxColumn
            // 
            prestamoIdDataGridViewTextBoxColumn.DataPropertyName = "PrestamoId";
            prestamoIdDataGridViewTextBoxColumn.HeaderText = "ID";
            prestamoIdDataGridViewTextBoxColumn.Name = "prestamoIdDataGridViewTextBoxColumn";
            prestamoIdDataGridViewTextBoxColumn.ReadOnly = true;
            prestamoIdDataGridViewTextBoxColumn.Width = 53;
            // 
            // usuarioIdDataGridViewTextBoxColumn1
            // 
            usuarioIdDataGridViewTextBoxColumn1.DataPropertyName = "UsuarioId";
            usuarioIdDataGridViewTextBoxColumn1.HeaderText = "UsuarioId";
            usuarioIdDataGridViewTextBoxColumn1.Name = "usuarioIdDataGridViewTextBoxColumn1";
            usuarioIdDataGridViewTextBoxColumn1.ReadOnly = true;
            usuarioIdDataGridViewTextBoxColumn1.Width = 112;
            // 
            // libroIdDataGridViewTextBoxColumn
            // 
            libroIdDataGridViewTextBoxColumn.DataPropertyName = "LibroId";
            libroIdDataGridViewTextBoxColumn.HeaderText = "LibroId";
            libroIdDataGridViewTextBoxColumn.Name = "libroIdDataGridViewTextBoxColumn";
            libroIdDataGridViewTextBoxColumn.ReadOnly = true;
            libroIdDataGridViewTextBoxColumn.Width = 92;
            // 
            // fechaPrestamoDataGridViewTextBoxColumn
            // 
            fechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrestamo";
            fechaPrestamoDataGridViewTextBoxColumn.HeaderText = "FechaPrestamo";
            fechaPrestamoDataGridViewTextBoxColumn.Name = "fechaPrestamoDataGridViewTextBoxColumn";
            fechaPrestamoDataGridViewTextBoxColumn.ReadOnly = true;
            fechaPrestamoDataGridViewTextBoxColumn.Width = 155;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            fechaDevolucionDataGridViewTextBoxColumn.ReadOnly = true;
            fechaDevolucionDataGridViewTextBoxColumn.Width = 168;
            // 
            // devueltoDataGridViewCheckBoxColumn
            // 
            devueltoDataGridViewCheckBoxColumn.DataPropertyName = "Devuelto";
            devueltoDataGridViewCheckBoxColumn.HeaderText = "Devuelto";
            devueltoDataGridViewCheckBoxColumn.Name = "devueltoDataGridViewCheckBoxColumn";
            devueltoDataGridViewCheckBoxColumn.Width = 87;
            // 
            // procesadoDataGridViewCheckBoxColumn
            // 
            procesadoDataGridViewCheckBoxColumn.DataPropertyName = "Procesado";
            procesadoDataGridViewCheckBoxColumn.HeaderText = "Procesado";
            procesadoDataGridViewCheckBoxColumn.Name = "procesadoDataGridViewCheckBoxColumn";
            procesadoDataGridViewCheckBoxColumn.ReadOnly = true;
            procesadoDataGridViewCheckBoxColumn.Visible = false;
            procesadoDataGridViewCheckBoxColumn.Width = 97;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            usuarioDataGridViewTextBoxColumn.Visible = false;
            usuarioDataGridViewTextBoxColumn.Width = 96;
            // 
            // librosDataGridViewTextBoxColumn
            // 
            librosDataGridViewTextBoxColumn.DataPropertyName = "Libros";
            librosDataGridViewTextBoxColumn.HeaderText = "Libros";
            librosDataGridViewTextBoxColumn.Name = "librosDataGridViewTextBoxColumn";
            librosDataGridViewTextBoxColumn.ReadOnly = true;
            librosDataGridViewTextBoxColumn.Visible = false;
            librosDataGridViewTextBoxColumn.Width = 84;
            // 
            // prestamosBindingSource
            // 
            prestamosBindingSource.DataSource = typeof(Prestamos);
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(579, 549);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 10;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Box_Usuario
            // 
            Box_Usuario.BorderStyle = BorderStyle.FixedSingle;
            Box_Usuario.Location = new Point(234, 549);
            Box_Usuario.Name = "Box_Usuario";
            Box_Usuario.Size = new Size(178, 29);
            Box_Usuario.TabIndex = 9;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 549);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 8;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1342, 549);
            button1.Name = "button1";
            button1.Size = new Size(183, 29);
            button1.TabIndex = 13;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(123, 549);
            button5.Name = "button5";
            button5.Size = new Size(105, 29);
            button5.TabIndex = 14;
            button5.Text = "eliminar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(850, 549);
            button4.Name = "button4";
            button4.Size = new Size(105, 29);
            button4.TabIndex = 17;
            button4.Text = "eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Box_Prestamo
            // 
            Box_Prestamo.BorderStyle = BorderStyle.FixedSingle;
            Box_Prestamo.Location = new Point(961, 549);
            Box_Prestamo.Name = "Box_Prestamo";
            Box_Prestamo.Size = new Size(178, 29);
            Box_Prestamo.TabIndex = 16;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(739, 549);
            button6.Name = "button6";
            button6.Size = new Size(105, 29);
            button6.TabIndex = 15;
            button6.Text = "Buscar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // formUsuarioPrestamos
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background_image_library_system;
            ClientSize = new Size(1532, 596);
            Controls.Add(button4);
            Controls.Add(Box_Prestamo);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(Box_Usuario);
            Controls.Add(button2);
            Controls.Add(dataGridViewPrestamo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewUsuario);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            ForeColor = Color.FromArgb(44, 62, 80);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "formUsuarioPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de control de libros";
            FormClosing += formUsuarioPrestamos_FormClosing;
            Load += formUsuarioPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).EndInit();
            ((System.ComponentModel.ISupportInitialize)prestamosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewPrestamo;
        private Button button3;
        private TextBox Box_Usuario;
        private Button button2;
        private Button button1;
        private Button button5;
        private BindingSource usuarioBindingSource;
        private Button button4;
        private TextBox Box_Prestamo;
        private Button button6;
        private BindingSource prestamosBindingSource;
        private DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prestamoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn libroIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn devueltoDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn procesadoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn librosDataGridViewTextBoxColumn;
    }
}