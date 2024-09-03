namespace Biblioteca
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLibros_Click(object sender, EventArgs e)
        {
            GestionarLibrosForm librosForm = new GestionarLibrosForm();
            librosForm.Show();
        }

        private void buttonMiembros_Click(object sender, EventArgs e)
        {
            GestionarMiembrosForm gestionarMiembros = new GestionarMiembrosForm();
            gestionarMiembros.Show();
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            GestionarPrestamosForm gestionarPrestamos = new GestionarPrestamosForm();
            gestionarPrestamos.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
