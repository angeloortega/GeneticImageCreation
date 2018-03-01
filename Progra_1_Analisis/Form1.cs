using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progra_1_Analisis.Utilities;
namespace Progra_1_Analisis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imagenObjetivo.SizeMode = PictureBoxSizeMode.Zoom;
            imagenGenerada.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imagenGenerada.Image = Utils.generarImagenAleatoria(100);
        }

        private void imgLoadBtn_Click(object sender, EventArgs e)
        {
            imagenObjetivo.Image = Utils.cargarImagen();
        }
    }
}
