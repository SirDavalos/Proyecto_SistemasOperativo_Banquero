namespace Proyecto_SistemasOperativo_Banquero
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormDatos F3 = new FormDatos();
            this.Hide();
            F3.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
