namespace Proyecto_SistemasOperativo_Banquero
{
    partial class FormIngresoInstancias
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
            btnRegresar = new Button();
            lblInstancias = new Label();
            btnInsertar = new Button();
            txtBoxInstancias = new TextBox();
            dataGridView1 = new DataGridView();
            Recursos = new DataGridViewTextBoxColumn();
            Instancias = new DataGridViewTextBoxColumn();
            txtBoxAviso = new TextBox();
            btnSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.MenuHighlight;
            btnRegresar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(24, 327);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 31);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblInstancias
            // 
            lblInstancias.AutoSize = true;
            lblInstancias.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstancias.ForeColor = SystemColors.MenuText;
            lblInstancias.Location = new Point(24, 19);
            lblInstancias.Name = "lblInstancias";
            lblInstancias.Size = new Size(67, 20);
            lblInstancias.TabIndex = 10;
            lblInstancias.Text = "Instancias";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ScrollBar;
            btnInsertar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(24, 79);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(87, 23);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += button1_Click;
            // 
            // txtBoxInstancias
            // 
            txtBoxInstancias.Location = new Point(24, 51);
            txtBoxInstancias.Name = "txtBoxInstancias";
            txtBoxInstancias.Size = new Size(67, 23);
            txtBoxInstancias.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Recursos, Instancias });
            dataGridView1.Location = new Point(49, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 176);
            dataGridView1.TabIndex = 15;
            // 
            // Recursos
            // 
            Recursos.HeaderText = "Recursos";
            Recursos.Name = "Recursos";
            // 
            // Instancias
            // 
            Instancias.HeaderText = "Instancias";
            Instancias.Name = "Instancias";
            // 
            // txtBoxAviso
            // 
            txtBoxAviso.Enabled = false;
            txtBoxAviso.Location = new Point(108, 16);
            txtBoxAviso.Name = "txtBoxAviso";
            txtBoxAviso.Size = new Size(210, 23);
            txtBoxAviso.TabIndex = 16;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.MenuHighlight;
            btnSiguiente.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(172, 327);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(134, 31);
            btnSiguiente.TabIndex = 17;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FormIngresoInstancias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(331, 369);
            Controls.Add(btnSiguiente);
            Controls.Add(txtBoxAviso);
            Controls.Add(dataGridView1);
            Controls.Add(txtBoxInstancias);
            Controls.Add(btnInsertar);
            Controls.Add(lblInstancias);
            Controls.Add(btnRegresar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormIngresoInstancias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Instancias";
            Load += FormIngresoDatos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegresar;
        private Label lblInstancias;
        private Button btnInsertar;
        private TextBox txtBoxInstancias;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Recursos;
        private DataGridViewTextBoxColumn Instancias;
        private TextBox txtBoxAviso;
        private Button btnSiguiente;
    }
}