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
    public partial class FormPrincipal : Form
    {
        int i = 0;
        static int clients, resources;
        static int[,] Maximum, Allocation, Need;
        static int[] Available, request, release;
        public FormPrincipal(int cl, int res, int[] av, int[,] Max, int[,] Alloc, int[,] Nd)
        {
            resources = res;
            Available = av;
            Maximum = Max;
            Allocation = Alloc;
            Need = Nd;
            av = Available;

            request = new int[resources];
            release = new int[resources];
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            int client = int.Parse(txtBoxCliente.Text);
            if (i >= resources)
            {
                txtBoxAviso.Text = "Se alcanzo el limite de recursos";
                if (IsRequestValid(client, request))
                {
                    AllocateResources(client, request);
                    if (IsSafeState())
                    {
                        MessageBox.Show("Solicitud Concedida");
                    }
                    else
                    {
                        DeallocateResources(client, request);
                        MessageBox.Show("Solicitud rechazada: no se cumple el estado seguro.");
                    }
                }
                else
                {
                    MessageBox.Show("Solicitud rechazada: no es válida.");
                }
            }
            else
            {
                request[i] = int.Parse(txtBoxCantRecursos.Text);
                clients = int.Parse(txtBoxCliente.Text);
                int n = dataGridViewRecursos.Rows.Add();
                dataGridViewRecursos.Rows[n].Cells[0].Value = (i + 1);
                dataGridViewRecursos.Rows[n].Cells[1].Value = txtBoxCantRecursos.Text;
                i++;
            }

        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int client = int.Parse(txtBoxCliente.Text);

            if (i >= resources)
            {
                for (int j = 0; j < resources; j++)
                {
                    Allocation[client, j] -= release[j];
                    Need[client, j] += release[j];
                    Available[j] += release[j];
                }
            }
            else
            {
                release[i] = int.Parse(txtBoxCantRecursos.Text);
                clients = int.Parse(txtBoxCliente.Text);
                int n = dataGridViewRecursos.Rows.Add();
                dataGridViewRecursos.Rows[n].Cells[0].Value = (i + 1);
                dataGridViewRecursos.Rows[n].Cells[1].Value = txtBoxCantRecursos.Text;
                i++;
            }

            MessageBox.Show("Recursos liberados.");
        }

        static bool IsRequestValid(int client, int[] request)
        {
            for (int i = 0; i < resources; i++)
            {
                if (request[i] > Need[client, i] || request[i] > Available[i])
                    return false;
            }
            return true;
        }

        //METODOS PARA LAS OPERACIONES
        static void AllocateResources(int client, int[] request)
        {
            for (int i = 0; i < resources; i++)
            {
                Available[i] -= request[i];
                Allocation[client, i] += request[i];
                Need[client, i] -= request[i];
            }
        }

        static void DeallocateResources(int client, int[] request)
        {
            for (int i = 0; i < resources; i++)
            {
                Available[i] += request[i];
                Allocation[client, i] -= request[i];
                Need[client, i] += request[i];
            }
        }

        static bool IsSafeState()
        {
            int[] work = (int[])Available.Clone();
            bool[] finish = new bool[clients];
            int count = 0;

            while (count < clients)
            {
                bool found = false;

                for (int i = 0; i < clients; i++)
                {
                    if (!finish[i])
                    {
                        bool canFinish = true;
                        for (int j = 0; j < resources; j++)
                        {
                            if (Need[i, j] > work[j])
                            {
                                canFinish = false;
                                break;
                            }
                        }

                        if (canFinish)
                        {
                            for (int j = 0; j < resources; j++)
                                work[j] += Allocation[i, j];

                            finish[i] = true;
                            found = true;
                            count++;
                        }
                    }
                }

                if (!found)
                    return false;
            }

            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            request = new int[resources];
            release = new int[resources];
            txtBoxAviso.Text = "";
            txtBoxCantRecursos.Text = "";
            txtBoxCliente.Text = "";
            for (int n = dataGridViewRecursos.Rows.Count-1; n < 0; n--)
            {
                dataGridViewRecursos.Rows.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBoxDisponibles.Text = string.Join(",", Available);
            listBoxAsignaciones.Items.Clear();
            listBoxNecesidades.Items.Clear();
            listBoxMaximos.Items.Clear();
            for (int i = 0; i < Allocation.GetLength(0); i++)
            {
                listBoxAsignaciones.Items.Add("\nCLIENTE" + (i + 1) + "\n");
                for (int j = 0; j < Allocation.GetLength(1); j++)
                {
                    listBoxAsignaciones.Items.Add(Allocation[i, j]);
                }
            }
            for (int i = 0; i < Need.GetLength(0); i++)
            {
                listBoxNecesidades.Items.Add("\nCLIENTE" + (i + 1) + "\n");
                for (int j = 0; j < Need.GetLength(1); j++)
                {
                    listBoxNecesidades.Items.Add(Need[i, j]);
                }
            }
            for (int i = 0; i < Maximum.GetLength(0); i++)
            {
                listBoxMaximos.Items.Add("\nCLIENTE" + (i + 1) + "\n");
                for (int j = 0; j < Maximum.GetLength(1); j++)
                {
                    listBoxMaximos.Items.Add(Maximum[i, j]);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormInicio F1 = new FormInicio();
            this.Close();
            F1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
