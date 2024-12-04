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
    public partial class FormMaximos : Form
    {
        int i, j;
        static int clients, resources;
        static int[,] Maximum, Allocation, Need;
        static int[] Available;
        public FormMaximos(int cl, int res, int[] av)
        {
            i = 0;
            j = 0;
            Available = av;
            clients = cl;
            resources = res;
            Maximum = new int[clients, resources];
            Allocation = new int[clients, resources];
            Need = new int[clients, resources];
            InitializeComponent();
            txtBoxClientes.Text = "Cliente 1";
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (i >= clients)
            {
                txtBoxAviso.Text = "Se ha alcanzado el maximo de clientes y recursos";
            }
            else if(i < clients)
            {
                if (j >= resources)
                {
                    i++;
                    j = 0;
                    txtBoxClientes.Text = "Cliente " + (i + 1);
                }
                    Maximum[i, j] = int.Parse(txtBoxIMaximos.Text);
                    Need[i, j] = Maximum[i, j];
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = i + 1;
                    dataGridView1.Rows[n].Cells[1].Value = j + 1;
                    dataGridView1.Rows[n].Cells[2].Value = txtBoxIMaximos.Text;
                    j++;
                
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormInicio F1 = new FormInicio();
            this.Close();
            F1.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormPrincipal F5 = new FormPrincipal(clients, resources, Available, Maximum, Allocation, Need);
            this.Close();
            F5.Show();
        }
    }
}
