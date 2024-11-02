namespace Sistema_de_Libreria
{
    partial class FormLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibro));
            label1 = new Label();
            Box_autor = new TextBox();
            label2 = new Label();
            Box_año = new TextBox();
            label3 = new Label();
            Box_titulo = new TextBox();
            label4 = new Label();
            Box_genero = new TextBox();
            label5 = new Label();
            Box_stock = new TextBox();
            label6 = new Label();
            button3 = new Button();
            Box_cantida = new TextBox();
            label7 = new Label();
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
            label1.TabIndex = 3;
            label1.Text = "Sistema de control de libros";
            // 
            // Box_autor
            // 
            Box_autor.BorderStyle = BorderStyle.FixedSingle;
            Box_autor.Location = new Point(12, 118);
            Box_autor.Name = "Box_autor";
            Box_autor.Size = new Size(197, 23);
            Box_autor.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 20;
            label2.Text = "Año de Publicacion";
            // 
            // Box_año
            // 
            Box_año.BorderStyle = BorderStyle.FixedSingle;
            Box_año.Location = new Point(12, 162);
            Box_año.Name = "Box_año";
            Box_año.Size = new Size(197, 23);
            Box_año.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 22;
            label3.Text = "Autor";
            // 
            // Box_titulo
            // 
            Box_titulo.BorderStyle = BorderStyle.FixedSingle;
            Box_titulo.Location = new Point(12, 74);
            Box_titulo.Name = "Box_titulo";
            Box_titulo.Size = new Size(197, 23);
            Box_titulo.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 51);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 24;
            label4.Text = "Titulo";
            // 
            // Box_genero
            // 
            Box_genero.BorderStyle = BorderStyle.FixedSingle;
            Box_genero.Location = new Point(11, 211);
            Box_genero.Name = "Box_genero";
            Box_genero.Size = new Size(197, 23);
            Box_genero.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 188);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 26;
            label5.Text = "Genero";
            // 
            // Box_stock
            // 
            Box_stock.BorderStyle = BorderStyle.FixedSingle;
            Box_stock.Location = new Point(12, 260);
            Box_stock.Name = "Box_stock";
            Box_stock.Size = new Size(197, 23);
            Box_stock.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 28;
            label6.Text = "Stock";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 352);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 30;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Box_cantida
            // 
            Box_cantida.BorderStyle = BorderStyle.FixedSingle;
            Box_cantida.Location = new Point(11, 304);
            Box_cantida.Name = "Box_cantida";
            Box_cantida.Size = new Size(197, 23);
            Box_cantida.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 286);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 31;
            label7.Text = "Cantida";
            // 
            // FormLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background_image_library_system;
            ClientSize = new Size(429, 414);
            Controls.Add(Box_cantida);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(Box_stock);
            Controls.Add(label6);
            Controls.Add(Box_genero);
            Controls.Add(label5);
            Controls.Add(Box_titulo);
            Controls.Add(label4);
            Controls.Add(Box_año);
            Controls.Add(label3);
            Controls.Add(Box_autor);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FormLibro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Libros";
            FormClosing += FormLibro_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Box_autor;
        private Label label2;
        private TextBox Box_año;
        private Label label3;
        private TextBox Box_titulo;
        private Label label4;
        private TextBox Box_genero;
        private Label label5;
        private TextBox Box_stock;
        private Label label6;
        private Button button3;
        private TextBox Box_cantida;
        private Label label7;
    }
}