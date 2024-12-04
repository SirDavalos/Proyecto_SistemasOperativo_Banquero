using Proyecto_SistemasOperativo_Banquero.Properties;
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
    public partial class FormIngresoInstancias : Form
    {
        static int[] Available;
        static int clients, resources;
        static int count = 0;
        public FormIngresoInstancias(int cl, int res)
        {
            clients = cl;
            resources = res;
            Available = new int[resources];
            InitializeComponent();
        }

        private void FormIngresoDatos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormInicio F1 = new FormInicio();
            this.Close();
            F1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count >= resources)
            {
                txtBoxAviso.Text = "Ya se alcanzo el maximo de recursos";
            }
            else
            {
                Available[count] = int.Parse(txtBoxInstancias.Text);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = count.ToString();
                dataGridView1.Rows[n].Cells[1].Value = txtBoxInstancias.Text;
                count++;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormMaximos F4 = new FormMaximos(clients, resources, Available);
            this.Close();
            F4.Show();
        }
    }
}
