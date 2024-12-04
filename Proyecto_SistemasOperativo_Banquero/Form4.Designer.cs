namespace Proyecto_SistemasOperativo_Banquero
{
    partial class FormMaximos
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
            dataGridView1 = new DataGridView();
            Clientes = new DataGridViewTextBoxColumn();
            Recursos = new DataGridViewTextBoxColumn();
            Maximos = new DataGridViewTextBoxColumn();
            txtBoxClientes = new TextBox();
            txtBoxAviso = new TextBox();
            txtBoxIMaximos = new TextBox();
            btnInsertar = new Button();
            lblMaximos = new Label();
            btnRegresar = new Button();
            btnSiguiente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Clientes, Recursos, Maximos });
            dataGridView1.Location = new Point(29, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(340, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Clientes
            // 
            Clientes.HeaderText = "Clientes";
            Clientes.Name = "Clientes";
            // 
            // Recursos
            // 
            Recursos.HeaderText = "Recurso";
            Recursos.Name = "Recursos";
            // 
            // Maximos
            // 
            Maximos.HeaderText = "Maximo";
            Maximos.Name = "Maximos";
            // 
            // txtBoxClientes
            // 
            txtBoxClientes.Enabled = false;
            txtBoxClientes.Location = new Point(28, 122);
            txtBoxClientes.Name = "txtBoxClientes";
            txtBoxClientes.Size = new Size(87, 23);
            txtBoxClientes.TabIndex = 1;
            // 
            // txtBoxAviso
            // 
            txtBoxAviso.Enabled = false;
            txtBoxAviso.Location = new Point(112, 18);
            txtBoxAviso.Name = "txtBoxAviso";
            txtBoxAviso.Size = new Size(210, 23);
            txtBoxAviso.TabIndex = 20;
            // 
            // txtBoxIMaximos
            // 
            txtBoxIMaximos.Location = new Point(28, 53);
            txtBoxIMaximos.Name = "txtBoxIMaximos";
            txtBoxIMaximos.Size = new Size(67, 23);
            txtBoxIMaximos.TabIndex = 19;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = SystemColors.ScrollBar;
            btnInsertar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(28, 81);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(87, 23);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblMaximos
            // 
            lblMaximos.AutoSize = true;
            lblMaximos.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaximos.ForeColor = SystemColors.MenuText;
            lblMaximos.Location = new Point(28, 21);
            lblMaximos.Name = "lblMaximos";
            lblMaximos.Size = new Size(63, 20);
            lblMaximos.TabIndex = 17;
            lblMaximos.Text = "Maximos";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.MenuHighlight;
            btnRegresar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(29, 322);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 31);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.MenuHighlight;
            btnSiguiente.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(250, 322);
            btnSiguiente.Margin = new Padding(3, 2, 3, 2);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(119, 31);
            btnSiguiente.TabIndex = 22;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FormMaximos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(394, 408);
            Controls.Add(btnSiguiente);
            Controls.Add(btnRegresar);
            Controls.Add(txtBoxAviso);
            Controls.Add(txtBoxIMaximos);
            Controls.Add(btnInsertar);
            Controls.Add(lblMaximos);
            Controls.Add(txtBoxClientes);
            Controls.Add(dataGridView1);
            Name = "FormMaximos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Maximos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBoxClientes;
        private TextBox txtBoxAviso;
        private TextBox txtBoxIMaximos;
        private Button btnInsertar;
        private Label lblMaximos;
        private Button btnRegresar;
        private DataGridViewTextBoxColumn Clientes;
        private DataGridViewTextBoxColumn Recursos;
        private DataGridViewTextBoxColumn Maximos;
        private Button btnSiguiente;
    }
}