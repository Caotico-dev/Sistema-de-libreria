namespace Sistema_de_Libreria
{
    partial class FormInico
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInico));
            label1 = new Label();
            dataGridViewlibros = new DataGridView();
            librosBindingSource = new BindingSource(components);
            label2 = new Label();
            button2 = new Button();
            Box_libro = new TextBox();
            button3 = new Button();
            LibroAgotado = new ListView();
            ID = new ColumnHeader();
            Titulo = new ColumnHeader();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            FechaVencida = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button5 = new Button();
            Actualizar = new Button();
            libroIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            autorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            generoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            añosPublicacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewlibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)librosBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 1;
            label1.Text = "Sistema de control de libros";
            // 
            // dataGridViewlibros
            // 
            dataGridViewlibros.AutoGenerateColumns = false;
            dataGridViewlibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewlibros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewlibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewlibros.Columns.AddRange(new DataGridViewColumn[] { libroIdDataGridViewTextBoxColumn, tituloDataGridViewTextBoxColumn, autorDataGridViewTextBoxColumn, generoDataGridViewTextBoxColumn, añosPublicacionDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn });
            dataGridViewlibros.DataSource = librosBindingSource;
            dataGridViewlibros.Location = new Point(12, 74);
            dataGridViewlibros.Name = "dataGridViewlibros";
            dataGridViewlibros.Size = new Size(810, 466);
            dataGridViewlibros.TabIndex = 2;
            // 
            // librosBindingSource
            // 
            librosBindingSource.DataSource = typeof(Libros);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 3;
            label2.Text = "Libros";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 546);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 5;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Box_libro
            // 
            Box_libro.BorderStyle = BorderStyle.FixedSingle;
            Box_libro.Location = new Point(234, 546);
            Box_libro.Name = "Box_libro";
            Box_libro.Size = new Size(234, 29);
            Box_libro.TabIndex = 6;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(717, 546);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 7;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LibroAgotado
            // 
            LibroAgotado.Columns.AddRange(new ColumnHeader[] { ID, Titulo });
            LibroAgotado.Location = new Point(828, 74);
            LibroAgotado.Name = "LibroAgotado";
            LibroAgotado.Size = new Size(270, 205);
            LibroAgotado.TabIndex = 8;
            LibroAgotado.UseCompatibleStateImageBehavior = false;
            LibroAgotado.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 40;
            // 
            // Titulo
            // 
            Titulo.Text = "Titulo";
            Titulo.Width = 200;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(828, 50);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 9;
            label3.Text = "Libros Agotados";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(606, 546);
            button1.Name = "button1";
            button1.Size = new Size(105, 29);
            button1.TabIndex = 10;
            button1.Text = "Prestamos";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(828, 282);
            label4.Name = "label4";
            label4.Size = new Size(215, 21);
            label4.TabIndex = 12;
            label4.Text = "Fecha de entrega vencidas";
            // 
            // FechaVencida
            // 
            FechaVencida.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5 });
            FechaVencida.Location = new Point(828, 306);
            FechaVencida.Name = "FechaVencida";
            FechaVencida.Size = new Size(303, 205);
            FechaVencida.TabIndex = 11;
            FechaVencida.UseCompatibleStateImageBehavior = false;
            FechaVencida.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Titulo";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha";
            columnHeader5.Width = 130;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(123, 546);
            button5.Name = "button5";
            button5.Size = new Size(105, 29);
            button5.TabIndex = 15;
            button5.Text = "eliminar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Actualizar
            // 
            Actualizar.FlatStyle = FlatStyle.Flat;
            Actualizar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Actualizar.Location = new Point(495, 545);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(105, 29);
            Actualizar.TabIndex = 16;
            Actualizar.Text = "Actualizar";
            Actualizar.UseMnemonic = false;
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Visible = false;
            Actualizar.Click += Actualizar_Click;
            // 
            // libroIdDataGridViewTextBoxColumn
            // 
            libroIdDataGridViewTextBoxColumn.DataPropertyName = "LibroId";
            libroIdDataGridViewTextBoxColumn.HeaderText = "ID";
            libroIdDataGridViewTextBoxColumn.Name = "libroIdDataGridViewTextBoxColumn";
            libroIdDataGridViewTextBoxColumn.ReadOnly = true;
            libroIdDataGridViewTextBoxColumn.Width = 53;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.ReadOnly = true;
            tituloDataGridViewTextBoxColumn.Width = 82;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            autorDataGridViewTextBoxColumn.ReadOnly = true;
            autorDataGridViewTextBoxColumn.Width = 81;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            generoDataGridViewTextBoxColumn.ReadOnly = true;
            generoDataGridViewTextBoxColumn.Width = 92;
            // 
            // añosPublicacionDataGridViewTextBoxColumn
            // 
            añosPublicacionDataGridViewTextBoxColumn.DataPropertyName = "AñosPublicacion";
            añosPublicacionDataGridViewTextBoxColumn.HeaderText = "Años Publicacion";
            añosPublicacionDataGridViewTextBoxColumn.Name = "añosPublicacionDataGridViewTextBoxColumn";
            añosPublicacionDataGridViewTextBoxColumn.ReadOnly = true;
            añosPublicacionDataGridViewTextBoxColumn.Width = 154;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            stockDataGridViewTextBoxColumn.Width = 78;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            cantidadDataGridViewTextBoxColumn.Width = 105;
            // 
            // FormInico
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background_image_library_system;
            ClientSize = new Size(1143, 630);
            Controls.Add(Actualizar);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(FechaVencida);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(LibroAgotado);
            Controls.Add(button3);
            Controls.Add(Box_libro);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dataGridViewlibros);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(44, 62, 80);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormInico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de control de libros";
            FormClosing += FormInico_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewlibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)librosBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewlibros;
        private Label label2;
        private Button button2;
        private TextBox Box_libro;
        private Button button3;
        private ListView LibroAgotado;
        private Label label3;
        private Button button1;
        private Label label4;
        private ListView FechaVencida;
        private Button button5;
        private BindingSource librosBindingSource;
        private Button Actualizar;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader ID;
        private ColumnHeader Titulo;
        private DataGridViewTextBoxColumn libroIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn añosPublicacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}
