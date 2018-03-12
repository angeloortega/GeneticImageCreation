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
using Progra_1_Analisis.Model;
using Progra_1_Analisis.Logic;

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

        private void imgLoadBtn_Click(object sender, EventArgs e)
        {
            imagenObjetivo.Image = Utils.cargarImagen();
        }

        private void iniciarEvolucion(object sender, EventArgs e)
        {

            
            if (!validateInput()) {
                MessageBox.Show("Por favor inserte parámetros correctos.", "Error en las configuraciones",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SingletonCache singleton = SingletonCache.Instance;
            singleton.DistGChecked = DistanciaGCheck.Checked;
            singleton.DistManChecked = DistanciaManCheck.Checked;
            singleton.histColorChecked = histColorCheck.Checked;
            singleton.histFormaChecked = histFormaCheck.Checked;
            singleton.tamPoblacion = Int32.Parse(entryPoblacion.Text);
            singleton.porcCruses = float.Parse(entryCruces.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            singleton.porcMenosApt = float.Parse(entryMenosApt.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            singleton.porcMutacion = float.Parse(entryMutacion.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            singleton.cantidadItereaciones = Int32.Parse(entryIteraciones.Text);
            AlgoritmoGenetico.primeraGeneracion();
            imagenGenerada.Image = singleton.poblacion[0].image;
            updateStatistics();

            for (int i = 0; i < SingletonCache.Instance.cantidadItereaciones; i++)
            {
                AlgoritmoGenetico.siguienteGeneracion();
                SingletonCache.Instance.numGeneracion++;

                updateStatistics();
            }

        }
        private void updateStatistics()
        {
            SingletonCache singleton = SingletonCache.Instance;
            if (singleton.indMasAptoGen.diferencia < singleton.indMasAptoHist.diferencia) {
                singleton.indMasAptoHist = singleton.indMasAptoGen;
            }
            if (singleton.indMenosAptoGen.diferencia > singleton.indMenosAptoHist.diferencia)
            {
                singleton.indMenosAptoHist = singleton.indMenosAptoGen;
            }
            imagenGenerada.Image = SingletonCache.Instance.poblacion[0].image;
            // update current gen stats
            lblGenNumber.Text = "Generación #" + singleton.numGeneracion;
            indMasAptoGen.Text = "Individuo más apto: " + (100.00 - singleton.poblacion[0].diferencia).ToString("0.000");
            indPromedioGen.Text = "Individuo promedio: " + (100.00 - singleton.indPromedioAptoGen).ToString("0.000");
            indMenosGen.Text = "Individuo menos apto: " + (100.00 - singleton.poblacion[SingletonCache.Instance.tamPoblacion - 1].diferencia).ToString("0.000");

            // update historic stats
            indMasHistor.Text = "Individuo más apto: " + (100.00 - singleton.indMasAptoHist.diferencia).ToString("0.000");
            indPromedioHistor.Text = "Individuo promedio: " + (100.00 - singleton.indPromedioAptoHist).ToString("0.000");
            indMenosHistor.Text = "Individuo menos apto: " + (100.00 - singleton.indMenosAptoHist.diferencia).ToString("0.000");
            Application.DoEvents();
        }
        private bool validateInput() {
            if (!Utils.IsDigitsOnly(entryPoblacion.Text)) {
                return false;
            }
            if (!Utils.IsDigitsOnly(entryCruces.Text))
            {
                return false;
            }
            if (!Utils.IsDigitsOnly(entryMenosApt.Text))
            {
                return false;
            }
            if (!Utils.IsDigitsOnly(entryMutacion.Text))
            {
                return false;
            }
            if (!Utils.IsDigitsOnly(entryIteraciones.Text)) {
                return false;
            }
            if (imagenObjetivo.Image == null)
            {
                return false;
            }
            return true;
        }

        private void statBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
