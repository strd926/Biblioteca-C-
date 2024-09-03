using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class GestionarLibrosForm : Form
    {
        private List<Libro> libros = new List<Libro>();

        public GestionarLibrosForm()
        {
            InitializeComponent();
        }

        private void GestionarLibrosForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUbicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregarLibro_Click(object sender, EventArgs e)
        {
            if (radioFisico.Checked)
            {
                LibroFisico libroFisico = new LibroFisico(textBoxTitulo.Text, textBoxAutor.Text, int.Parse(textBoxPublicacion.Text), textBoxUbicacion.Text);
                libros.Add(libroFisico);
            }
            else if (radioElectronico.Checked)
            {
                LibroElectronico libroElectronico = new LibroElectronico(textBoxTitulo.Text, textBoxAutor.Text, int.Parse(textBoxPublicacion.Text), double.Parse(textBoxTamano.Text), textBoxFormato.Text);
                libros.Add(libroElectronico);
            }
            ActualizarListaLibros();

            textBoxAutor.Clear();
            textBoxFormato.Clear();
            textBoxPublicacion.Clear();
            textBoxTamano.Clear();
            textBoxTitulo.Clear();
            textBoxUbicacion.Clear();
            radioElectronico.Checked = false;
            radioFisico.Checked = false;
        }

        private void ActualizarListaLibros()
        {
            listBoxLibros.Items.Clear();
            foreach (var libro in libros)
            {
                listBoxLibros.Items.Add(libro.ObtenerDetalles());
            }
        }
    }
}

