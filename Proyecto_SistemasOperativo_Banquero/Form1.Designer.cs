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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 27);
            label1.TabIndex = 0;
            label1.Text = "Algoritmo de Banquero";
            // 
            // labelIntegrantes
            // 
            labelIntegrantes.AutoSize = true;
            labelIntegrantes.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIntegrantes.Location = new Point(12, 90);
            labelIntegrantes.Name = "labelIntegrantes";
            labelIntegrantes.Size = new Size(138, 27);
            labelIntegrantes.TabIndex = 1;
            labelIntegrantes.Text = "Integrantes";
            // 
            // listBoxIntegrantes
            // 
            listBoxIntegrantes.BackColor = Color.Moccasin;
            listBoxIntegrantes.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxIntegrantes.FormattingEnabled = true;
            listBoxIntegrantes.ItemHeight = 21;
            listBoxIntegrantes.Items.AddRange(new object[] { "Fernando Davalos Gutierrez", "Hector Guerrero Villa", "Cesar" });
            listBoxIntegrantes.Location = new Point(12, 120);
            listBoxIntegrantes.Name = "listBoxIntegrantes";
            listBoxIntegrantes.Size = new Size(238, 109);
            listBoxIntegrantes.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(306, 342);
            button1.Name = "button1";
            button1.Size = new Size(226, 68);
            button1.TabIndex = 4;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Banco;
            pictureBox1.Location = new Point(276, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBoxIntegrantes);
            Controls.Add(labelIntegrantes);
            Controls.Add(label1);
            Name = "FormInicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelIntegrantes;
        private ListBox listBoxIntegrantes;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
