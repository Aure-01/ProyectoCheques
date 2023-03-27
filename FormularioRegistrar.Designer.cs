namespace ProyectoCheques
{
    partial class FormularioRegistrar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnCancelar = new Button();
            txtCorreo = new TextBox();
            btnRegistrarUsuario = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 54);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(112, 123);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(87, 175);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(117, 232);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(184, 123);
            txtUsuario.MaxLength = 100;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(250, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(184, 175);
            txtContrasena.MaxLength = 50;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(250, 23);
            txtContrasena.TabIndex = 5;
            txtContrasena.TextChanged += txtContrasena_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(481, 353);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 42);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(184, 228);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 23);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarUsuario.Location = new Point(169, 353);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(118, 42);
            btnRegistrarUsuario.TabIndex = 9;
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // FormularioRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(txtCorreo);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioRegistrar";
            Text = "FormularioRegistrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnCancelar;
        private TextBox txtCorreo;
        private Button btnRegistrarUsuario;
    }
}