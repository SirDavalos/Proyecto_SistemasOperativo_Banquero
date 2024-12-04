namespace Proyecto_SistemasOperativo_Banquero
{
    partial class FormInicio
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
            label1 = new Label();
            labelIntegrantes = new Label();
            listBoxIntegrantes = new ListBox();
            btnIniciar = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 7);
            label1.Name = "label1";
            label1.Size = new Size(225, 22);
            label1.TabIndex = 0;
            label1.Text = "Algoritmo de Banquero";
            // 
            // labelIntegrantes
            // 
            labelIntegrantes.AutoSize = true;
            labelIntegrantes.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIntegrantes.Location = new Point(10, 68);
            labelIntegrantes.Name = "labelIntegrantes";
            labelIntegrantes.Size = new Size(115, 22);
            labelIntegrantes.TabIndex = 1;
            labelIntegrantes.Text = "Integrantes";
            // 
            // listBoxIntegrantes
            // 
            listBoxIntegrantes.BackColor = Color.Moccasin;
            listBoxIntegrantes.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxIntegrantes.FormattingEnabled = true;
            listBoxIntegrantes.Items.AddRange(new object[] { "Fernando Davalos Gutierrez", "Hector Guerrero Villa", "Cesar" });
            listBoxIntegrantes.Location = new Point(10, 90);
            listBoxIntegrantes.Margin = new Padding(3, 2, 3, 2);
            listBoxIntegrantes.Name = "listBoxIntegrantes";
            listBoxIntegrantes.Size = new Size(209, 68);
            listBoxIntegrantes.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.MenuHighlight;
            btnIniciar.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(242, 252);
            btnIniciar.Margin = new Padding(3, 2, 3, 2);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(103, 51);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Banco;
            pictureBox1.Location = new Point(242, 47);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 192);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.MenuHighlight;
            btnSalir.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(369, 252);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(97, 51);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciar);
            Controls.Add(listBoxIntegrantes);
            Controls.Add(labelIntegrantes);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelIntegrantes;
        private ListBox listBoxIntegrantes;
        private Button btnIniciar;
        private PictureBox pictureBox1;
        private Button btnSalir;
    }
}
