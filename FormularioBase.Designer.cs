namespace ProyectoCheques
{
    partial class FormularioBase
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoChequeToolStripMenuItem = new ToolStripMenuItem();
            nuevoBeneficiarioToolStripMenuItem = new ToolStripMenuItem();
            nuevaCuentaBancariaToolStripMenuItem = new ToolStripMenuItem();
            nuevoChequeToolStripMenuItem1 = new ToolStripMenuItem();
            editarChequeToolStripMenuItem = new ToolStripMenuItem();
            eliminarChequeToolStripMenuItem = new ToolStripMenuItem();
            nuevoBeneficiarioToolStripMenuItem1 = new ToolStripMenuItem();
            editarBeneficiarioToolStripMenuItem = new ToolStripMenuItem();
            eliminarBeneficiarioToolStripMenuItem = new ToolStripMenuItem();
            nuevaCuentaBancariaToolStripMenuItem1 = new ToolStripMenuItem();
            editarCuentaBancariaToolStripMenuItem = new ToolStripMenuItem();
            eliminarCuentaBancariaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoChequeToolStripMenuItem, nuevoBeneficiarioToolStripMenuItem, nuevaCuentaBancariaToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoChequeToolStripMenuItem
            // 
            nuevoChequeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoChequeToolStripMenuItem1, editarChequeToolStripMenuItem, eliminarChequeToolStripMenuItem });
            nuevoChequeToolStripMenuItem.Name = "nuevoChequeToolStripMenuItem";
            nuevoChequeToolStripMenuItem.Size = new Size(180, 22);
            nuevoChequeToolStripMenuItem.Text = "Cheque";
            // 
            // nuevoBeneficiarioToolStripMenuItem
            // 
            nuevoBeneficiarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoBeneficiarioToolStripMenuItem1, editarBeneficiarioToolStripMenuItem, eliminarBeneficiarioToolStripMenuItem });
            nuevoBeneficiarioToolStripMenuItem.Name = "nuevoBeneficiarioToolStripMenuItem";
            nuevoBeneficiarioToolStripMenuItem.Size = new Size(180, 22);
            nuevoBeneficiarioToolStripMenuItem.Text = "Beneficiario";
            // 
            // nuevaCuentaBancariaToolStripMenuItem
            // 
            nuevaCuentaBancariaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaCuentaBancariaToolStripMenuItem1, editarCuentaBancariaToolStripMenuItem, eliminarCuentaBancariaToolStripMenuItem });
            nuevaCuentaBancariaToolStripMenuItem.Name = "nuevaCuentaBancariaToolStripMenuItem";
            nuevaCuentaBancariaToolStripMenuItem.Size = new Size(180, 22);
            nuevaCuentaBancariaToolStripMenuItem.Text = "Cuenta Bancaria";
            // 
            // nuevoChequeToolStripMenuItem1
            // 
            nuevoChequeToolStripMenuItem1.Name = "nuevoChequeToolStripMenuItem1";
            nuevoChequeToolStripMenuItem1.Size = new Size(180, 22);
            nuevoChequeToolStripMenuItem1.Text = "Nuevo Cheque";
            nuevoChequeToolStripMenuItem1.Click += nuevoChequeToolStripMenuItem1_Click;
            // 
            // editarChequeToolStripMenuItem
            // 
            editarChequeToolStripMenuItem.Name = "editarChequeToolStripMenuItem";
            editarChequeToolStripMenuItem.Size = new Size(180, 22);
            editarChequeToolStripMenuItem.Text = "Editar Cheque";
            editarChequeToolStripMenuItem.Click += editarChequeToolStripMenuItem_Click;
            // 
            // eliminarChequeToolStripMenuItem
            // 
            eliminarChequeToolStripMenuItem.Name = "eliminarChequeToolStripMenuItem";
            eliminarChequeToolStripMenuItem.Size = new Size(180, 22);
            eliminarChequeToolStripMenuItem.Text = "Eliminar Cheque";
            eliminarChequeToolStripMenuItem.Click += eliminarChequeToolStripMenuItem_Click;
            // 
            // nuevoBeneficiarioToolStripMenuItem1
            // 
            nuevoBeneficiarioToolStripMenuItem1.Name = "nuevoBeneficiarioToolStripMenuItem1";
            nuevoBeneficiarioToolStripMenuItem1.Size = new Size(182, 22);
            nuevoBeneficiarioToolStripMenuItem1.Text = "Nuevo Beneficiario";
            nuevoBeneficiarioToolStripMenuItem1.Click += nuevoBeneficiarioToolStripMenuItem1_Click;
            // 
            // editarBeneficiarioToolStripMenuItem
            // 
            editarBeneficiarioToolStripMenuItem.Name = "editarBeneficiarioToolStripMenuItem";
            editarBeneficiarioToolStripMenuItem.Size = new Size(182, 22);
            editarBeneficiarioToolStripMenuItem.Text = "Editar Beneficiario";
            editarBeneficiarioToolStripMenuItem.Click += editarBeneficiarioToolStripMenuItem_Click;
            // 
            // eliminarBeneficiarioToolStripMenuItem
            // 
            eliminarBeneficiarioToolStripMenuItem.Name = "eliminarBeneficiarioToolStripMenuItem";
            eliminarBeneficiarioToolStripMenuItem.Size = new Size(182, 22);
            eliminarBeneficiarioToolStripMenuItem.Text = "Eliminar Beneficiario";
            eliminarBeneficiarioToolStripMenuItem.Click += eliminarBeneficiarioToolStripMenuItem_Click;
            // 
            // nuevaCuentaBancariaToolStripMenuItem1
            // 
            nuevaCuentaBancariaToolStripMenuItem1.Name = "nuevaCuentaBancariaToolStripMenuItem1";
            nuevaCuentaBancariaToolStripMenuItem1.Size = new Size(206, 22);
            nuevaCuentaBancariaToolStripMenuItem1.Text = "Nueva Cuenta Bancaria";
            nuevaCuentaBancariaToolStripMenuItem1.Click += nuevaCuentaBancariaToolStripMenuItem1_Click;
            // 
            // editarCuentaBancariaToolStripMenuItem
            // 
            editarCuentaBancariaToolStripMenuItem.Name = "editarCuentaBancariaToolStripMenuItem";
            editarCuentaBancariaToolStripMenuItem.Size = new Size(206, 22);
            editarCuentaBancariaToolStripMenuItem.Text = "Editar Cuenta Bancaria";
            editarCuentaBancariaToolStripMenuItem.Click += editarCuentaBancariaToolStripMenuItem_Click;
            // 
            // eliminarCuentaBancariaToolStripMenuItem
            // 
            eliminarCuentaBancariaToolStripMenuItem.Name = "eliminarCuentaBancariaToolStripMenuItem";
            eliminarCuentaBancariaToolStripMenuItem.Size = new Size(206, 22);
            eliminarCuentaBancariaToolStripMenuItem.Text = "Eliminar Cuenta Bancaria";
            eliminarCuentaBancariaToolStripMenuItem.Click += eliminarCuentaBancariaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(51, 35);
            label1.Name = "label1";
            label1.Size = new Size(703, 54);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido al Sistema de Cheques";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(141, 217);
            label2.Name = "label2";
            label2.Size = new Size(232, 43);
            label2.TabIndex = 2;
            label2.Text = "Saldo Actual: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(396, 220);
            label3.Name = "label3";
            label3.Size = new Size(35, 40);
            label3.TabIndex = 3;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(366, 220);
            label4.Name = "label4";
            label4.Size = new Size(35, 40);
            label4.TabIndex = 4;
            label4.Text = "$";
            // 
            // FormularioBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormularioBase";
            Text = "FormularioBase";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoChequeToolStripMenuItem;
        private ToolStripMenuItem nuevoChequeToolStripMenuItem1;
        private ToolStripMenuItem editarChequeToolStripMenuItem;
        private ToolStripMenuItem eliminarChequeToolStripMenuItem;
        private ToolStripMenuItem nuevoBeneficiarioToolStripMenuItem;
        private ToolStripMenuItem nuevoBeneficiarioToolStripMenuItem1;
        private ToolStripMenuItem editarBeneficiarioToolStripMenuItem;
        private ToolStripMenuItem eliminarBeneficiarioToolStripMenuItem;
        private ToolStripMenuItem nuevaCuentaBancariaToolStripMenuItem;
        private ToolStripMenuItem nuevaCuentaBancariaToolStripMenuItem1;
        private ToolStripMenuItem editarCuentaBancariaToolStripMenuItem;
        private ToolStripMenuItem eliminarCuentaBancariaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}