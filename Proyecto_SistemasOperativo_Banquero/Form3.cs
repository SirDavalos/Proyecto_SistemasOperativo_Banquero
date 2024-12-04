using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SistemasOperativo_Banquero
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int clients = int.Parse(txtBoxClientes.Text);
            int resources = int.Parse(txtBoxRecursos.Text);
            FormIngresoInstancias F2 = new FormIngresoInstancias(clients, resources);
            this.Hide();
            F2.Show();
        }
    }
}
