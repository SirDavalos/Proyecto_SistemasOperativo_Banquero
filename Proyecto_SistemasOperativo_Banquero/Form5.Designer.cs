namespace Proyecto_SistemasOperativo_Banquero
{
    partial class FormPrincipal
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
            btnSolicitar = new Button();
            btnLiberar = new Button();
            btnVerEstructura = new Button();
            lblCliente = new Label();
            lblRecursos = new Label();
            txtBoxCliente = new TextBox();
            txtBoxCantRecursos = new TextBox();
            dataGridViewRecursos = new DataGridView();
            Recursos = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            txtBoxAviso = new TextBox();
            btnLimpiar = new Button();
            lblAsignaciones = new Label();
            listBoxAsignaciones = new ListBox();
            listBoxMaximos = new ListBox();
            listBoxNecesidades = new ListBox();
            lblNecesidades = new Label();
            lblMaximos = new Label();
            txtBoxDisponibles = new TextBox();
            lblDisponibles = new Label();
            btnRegresar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecursos).BeginInit();
            SuspendLayout();
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(57, 103);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(148, 23);
            btnSolicitar.TabIndex = 0;
            btnSolicitar.Text = "Solicitar Recurso";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // btnLiberar
            // 
            btnLiberar.Location = new Point(57, 157);
            btnLiberar.Name = "btnLiberar";
            btnLiberar.Size = new Size(148, 23);
            btnLiberar.TabIndex = 1;
            btnLiberar.Text = "Liberar recurso";
            btnLiberar.UseVisualStyleBackColor = true;
            btnLiberar.Click += btnLiberar_Click;
            // 
            // btnVerEstructura
            // 
            btnVerEstructura.Location = new Point(353, 523);
            btnVerEstructura.Name = "btnVerEstructura";
            btnVerEstructura.Size = new Size(148, 23);
            btnVerEstructura.TabIndex = 3;
            btnVerEstructura.Text = "Ver estructura de datos";
            btnVerEstructura.UseVisualStyleBackColor = true;
            btnVerEstructura.Click += button4_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(14, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 16);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "ID de cliente";
            // 
            // lblRecursos
            // 
            lblRecursos.AutoSize = true;
            lblRecursos.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecursos.Location = new Point(14, 64);
            lblRecursos.Name = "lblRecursos";
            lblRecursos.Size = new Size(47, 16);
            lblRecursos.TabIndex = 5;
            lblRecursos.Text = "Recurso";
            // 
            // txtBoxCliente
            // 
            txtBoxCliente.Location = new Point(83, 18);
            txtBoxCliente.Name = "txtBoxCliente";
            txtBoxCliente.Size = new Size(100, 23);
            txtBoxCliente.TabIndex = 6;
            // 
            // txtBoxCantRecursos
            // 
            txtBoxCantRecursos.Location = new Point(83, 57);
            txtBoxCantRecursos.Name = "txtBoxCantRecursos";
            txtBoxCantRecursos.Size = new Size(100, 23);
            txtBoxCantRecursos.TabIndex = 7;
            // 
            // dataGridViewRecursos
            // 
            dataGridViewRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecursos.Columns.AddRange(new DataGridViewColumn[] { Recursos, Valor });
            dataGridViewRecursos.Location = new Point(234, 12);
            dataGridViewRecursos.Name = "dataGridViewRecursos";
            dataGridViewRecursos.Size = new Size(221, 211);
            dataGridViewRecursos.TabIndex = 8;
            // 
            // Recursos
            // 
            Recursos.HeaderText = "Recurso";
            Recursos.Name = "Recursos";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // txtBoxAviso
            // 
            txtBoxAviso.Enabled = false;
            txtBoxAviso.Location = new Point(234, 229);
            txtBoxAviso.Name = "txtBoxAviso";
            txtBoxAviso.Size = new Size(221, 23);
            txtBoxAviso.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(57, 200);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(148, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblAsignaciones
            // 
            lblAsignaciones.AutoSize = true;
            lblAsignaciones.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignaciones.Location = new Point(539, 11);
            lblAsignaciones.Name = "lblAsignaciones";
            lblAsignaciones.Size = new Size(113, 19);
            lblAsignaciones.TabIndex = 12;
            lblAsignaciones.Text = "Asignaciones";
            // 
            // listBoxAsignaciones
            // 
            listBoxAsignaciones.FormattingEnabled = true;
            listBoxAsignaciones.ItemHeight = 15;
            listBoxAsignaciones.Location = new Point(539, 41);
            listBoxAsignaciones.Name = "listBoxAsignaciones";
            listBoxAsignaciones.Size = new Size(198, 139);
            listBoxAsignaciones.TabIndex = 13;
            // 
            // listBoxMaximos
            // 
            listBoxMaximos.FormattingEnabled = true;
            listBoxMaximos.ItemHeight = 15;
            listBoxMaximos.Location = new Point(539, 407);
            listBoxMaximos.Name = "listBoxMaximos";
            listBoxMaximos.Size = new Size(198, 139);
            listBoxMaximos.TabIndex = 14;
            // 
            // listBoxNecesidades
            // 
            listBoxNecesidades.FormattingEnabled = true;
            listBoxNecesidades.ItemHeight = 15;
            listBoxNecesidades.Location = new Point(539, 229);
            listBoxNecesidades.Name = "listBoxNecesidades";
            listBoxNecesidades.Size = new Size(198, 139);
            listBoxNecesidades.TabIndex = 15;
            // 
            // lblNecesidades
            // 
            lblNecesidades.AutoSize = true;
            lblNecesidades.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNecesidades.Location = new Point(539, 204);
            lblNecesidades.Name = "lblNecesidades";
            lblNecesidades.Size = new Size(108, 19);
            lblNecesidades.TabIndex = 16;
            lblNecesidades.Text = "Necesidades";
            // 
            // lblMaximos
            // 
            lblMaximos.AutoSize = true;
            lblMaximos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaximos.Location = new Point(539, 385);
            lblMaximos.Name = "lblMaximos";
            lblMaximos.Size = new Size(77, 19);
            lblMaximos.TabIndex = 17;
            lblMaximos.Text = "Maximos";
            // 
            // txtBoxDisponibles
            // 
            txtBoxDisponibles.Location = new Point(344, 345);
            txtBoxDisponibles.Name = "txtBoxDisponibles";
            txtBoxDisponibles.Size = new Size(111, 23);
            txtBoxDisponibles.TabIndex = 18;
            // 
            // lblDisponibles
            // 
            lblDisponibles.AutoSize = true;
            lblDisponibles.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisponibles.Location = new Point(344, 307);
            lblDisponibles.Name = "lblDisponibles";
            lblDisponibles.Size = new Size(100, 19);
            lblDisponibles.TabIndex = 19;
            lblDisponibles.Text = "Disponibles";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = SystemColors.MenuHighlight;
            btnRegresar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(14, 523);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(119, 31);
            btnRegresar.TabIndex = 20;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.MenuHighlight;
            btnSalir.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(160, 523);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(119, 31);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(763, 624);
            Controls.Add(btnSalir);
            Controls.Add(btnRegresar);
            Controls.Add(lblDisponibles);
            Controls.Add(txtBoxDisponibles);
            Controls.Add(lblMaximos);
            Controls.Add(lblNecesidades);
            Controls.Add(listBoxNecesidades);
            Controls.Add(listBoxMaximos);
            Controls.Add(listBoxAsignaciones);
            Controls.Add(lblAsignaciones);
            Controls.Add(btnLimpiar);
            Controls.Add(txtBoxAviso);
            Controls.Add(dataGridViewRecursos);
            Controls.Add(txtBoxCantRecursos);
            Controls.Add(txtBoxCliente);
            Controls.Add(lblRecursos);
            Controls.Add(lblCliente);
            Controls.Add(btnVerEstructura);
            Controls.Add(btnLiberar);
            Controls.Add(btnSolicitar);
            Name = "FormPrincipal";
            Text = "Menu de Opciones";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVerEstructura;
        private Button btnLiberar;
        private Button btnSolicitar;
        private Label lblCliente;
        private Label lblRecursos;
        private TextBox txtBoxCliente;
        private TextBox txtBoxCantRecursos;
        private DataGridView dataGridViewRecursos;
        private DataGridViewTextBoxColumn Recursos;
        private DataGridViewTextBoxColumn Valor;
        private TextBox txtBoxAviso;
        private Button btnLimpiar;
        private Label lblAsignaciones;
        private ListBox listBoxAsignaciones;
        private ListBox listBoxMaximos;
        private ListBox listBoxNecesidades;
        private Label lblNecesidades;
        private Label lblMaximos;
        private TextBox txtBoxDisponibles;
        private Label lblDisponibles;
        private Button btnRegresar;
        private Button btnSalir;
    }
}