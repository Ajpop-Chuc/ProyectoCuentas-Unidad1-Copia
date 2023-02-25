namespace ProyectoCuentas_Unidad1_
{
    public partial class FormMenuInicial : Form
    {
        public FormMenuInicial()
        {
            InitializeComponent();
        }

        private void btnIngresarMovimiento_Click(object sender, EventArgs e)
        {
            Form openform = new FormNuevoMovimiento();
            openform.Show();
        }
    }
}