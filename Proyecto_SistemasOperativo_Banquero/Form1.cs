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
            FormIngresoDatos F2 = new FormIngresoDatos();
            this.Hide();
            F2.Show();
        }
    }
}
