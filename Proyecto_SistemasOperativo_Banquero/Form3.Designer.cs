namespace Proyecto_SistemasOperativo_Banquero
{
    partial class FormDatos
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
            lblClientes = new Label();
            lblRecursos = new Label();
            txtBoxClientes = new TextBox();
            txtBoxRecursos = new TextBox();
            groupBoxDatos = new GroupBox();
            btnNext = new Button();
            groupBoxDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClientes.ForeColor = SystemColors.MenuText;
            lblClientes.Location = new Point(4, 24);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(57, 20);
            lblClientes.TabIndex = 11;
            lblClientes.Text = "Clientes";
            // 
            // lblRecursos
            // 
            lblRecursos.AutoSize = true;
            lblRecursos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecursos.ForeColor = SystemColors.MenuText;
            lblRecursos.Location = new Point(4, 78);
            lblRecursos.Name = "lblRecursos";
            lblRecursos.Size = new Size(66, 20);
            lblRecursos.TabIndex = 12;
            lblRecursos.Text = "Recursos";
            // 
            // txtBoxClientes
            // 
            txtBoxClientes.Location = new Point(76, 25);
            txtBoxClientes.Name = "txtBoxClientes";
            txtBoxClientes.Size = new Size(58, 23);
            txtBoxClientes.TabIndex = 13;
            // 
            // txtBoxRecursos
            // 
            txtBoxRecursos.Location = new Point(76, 75);
            txtBoxRecursos.Name = "txtBoxRecursos";
            txtBoxRecursos.Size = new Size(58, 23);
            txtBoxRecursos.TabIndex = 14;
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.Controls.Add(txtBoxRecursos);
            groupBoxDatos.Controls.Add(txtBoxClientes);
            groupBoxDatos.Controls.Add(lblRecursos);
            groupBoxDatos.Controls.Add(lblClientes);
            groupBoxDatos.Location = new Point(8, 48);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(155, 126);
            groupBoxDatos.TabIndex = 15;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(53, 192);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 16;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(187, 237);
            Controls.Add(btnNext);
            Controls.Add(groupBoxDatos);
            Name = "FormDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Datos";
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblClientes;
        private Label lblRecursos;
        private TextBox txtBoxClientes;
        private TextBox txtBoxRecursos;
        private GroupBox groupBoxDatos;
        private Button btnNext;
    }
}