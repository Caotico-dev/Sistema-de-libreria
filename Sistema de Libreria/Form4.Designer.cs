namespace Sistema_de_Libreria
{
    partial class FormPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamos));
            label1 = new Label();
            Box_UsuarioId = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            Box_LibroId = new TextBox();
            dateTimePicker1 = new DateTimePicker();
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
            label1.TabIndex = 2;
            label1.Text = "Sistema de control de libros";
            // 
            // Box_UsuarioId
            // 
            Box_UsuarioId.BorderStyle = BorderStyle.FixedSingle;
            Box_UsuarioId.Location = new Point(12, 75);
            Box_UsuarioId.Name = "Box_UsuarioId";
            Box_UsuarioId.Size = new Size(197, 29);
            Box_UsuarioId.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 180);
            label5.Name = "label5";
            label5.Size = new Size(145, 21);
            label5.TabIndex = 16;
            label5.Text = "Fecha devolucion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 15;
            label3.Text = "LibroId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 14;
            label2.Text = "UsuarioId";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 252);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 20;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Box_LibroId
            // 
            Box_LibroId.BorderStyle = BorderStyle.FixedSingle;
            Box_LibroId.Location = new Point(12, 139);
            Box_LibroId.Name = "Box_LibroId";
            Box_LibroId.Size = new Size(197, 29);
            Box_LibroId.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.Value = new DateTime(2024, 10, 29, 0, 0, 0, 0);
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background_image_library_system;
            ClientSize = new Size(391, 310);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(Box_UsuarioId);
            Controls.Add(Box_LibroId);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Prestamos";
            FormClosing += FormPrestamos_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Box_UsuarioId;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button button3;
        private TextBox Box_LibroId;
        private DateTimePicker dateTimePicker1;
    }
}