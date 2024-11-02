namespace Sistema_de_Libreria
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Box_direccion = new TextBox();
            Box_telefono = new TextBox();
            Box_Correo = new TextBox();
            Box_nombre = new TextBox();
            button3 = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 4;
            label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 248);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 178);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // Box_direccion
            // 
            Box_direccion.BorderStyle = BorderStyle.FixedSingle;
            Box_direccion.Location = new Point(9, 271);
            Box_direccion.Name = "Box_direccion";
            Box_direccion.Size = new Size(200, 28);
            Box_direccion.TabIndex = 10;
            // 
            // Box_telefono
            // 
            Box_telefono.BorderStyle = BorderStyle.FixedSingle;
            Box_telefono.Location = new Point(12, 201);
            Box_telefono.Name = "Box_telefono";
            Box_telefono.Size = new Size(197, 28);
            Box_telefono.TabIndex = 11;
            // 
            // Box_Correo
            // 
            Box_Correo.BorderStyle = BorderStyle.FixedSingle;
            Box_Correo.Location = new Point(12, 137);
            Box_Correo.Name = "Box_Correo";
            Box_Correo.Size = new Size(197, 28);
            Box_Correo.TabIndex = 12;
            // 
            // Box_nombre
            // 
            Box_nombre.BorderStyle = BorderStyle.FixedSingle;
            Box_nombre.Location = new Point(12, 73);
            Box_nombre.Name = "Box_nombre";
            Box_nombre.Size = new Size(197, 28);
            Box_nombre.TabIndex = 13;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(9, 315);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 14;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.background_image_library_system;
            ClientSize = new Size(400, 405);
            Controls.Add(button3);
            Controls.Add(Box_nombre);
            Controls.Add(Box_Correo);
            Controls.Add(Box_telefono);
            Controls.Add(Box_direccion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Usuarios";
            FormClosing += FormUsuario_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Box_direccion;
        private TextBox Box_telefono;
        private TextBox Box_Correo;
        private TextBox Box_nombre;
        private Button button3;
    }
}