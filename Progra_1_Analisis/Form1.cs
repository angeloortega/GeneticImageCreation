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
        public int pixel = 32;
        private bool continuar = true;
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
            if (pixel128.Checked)
            {
                pixel = 128;
                imagenObjetivo.Image = Utils.cargarImagen(128);
            }
            else if (pixel64.Checked)
            {
                pixel = 64;
                imagenObjetivo.Image = Utils.cargarImagen(64);
            }
            else if (pixel32.Checked)
            {
                pixel = 32;
                imagenObjetivo.Image = Utils.cargarImagen(32);
            }
            else
            {
                MessageBox.Show("Por favor indique la resolucion en la que desea procesar la imagen.", "Error en las configuraciones",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iniciarEvolucion(object sender, EventArgs e)
        {
            List<Imagen> imagenesFinales = new List<Imagen>();
            if (!validateInput()) {
                MessageBox.Show("Por favor inserte parámetros correctos.", "Error en las configuraciones",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            button1.Text = "Detener";
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
            SingletonCache.crearEstadisticas();
            AlgoritmoGenetico.primeraGeneracion(pixel);
            imagenGenerada.Image = singleton.poblacion[0].image;
            singleton.indMenosAptoHist = singleton.poblacion[singleton.tamPoblacion - 1];
            singleton.indMasAptoHist = singleton.poblacion[0];
            updateStatistics();
            singleton.objetivo.calcularDiferencia(singleton.objetivo);
            Console.WriteLine(singleton.objetivo.diferencia);
            bool trampa = conTrampaCheck.Checked;
            if (trampa)
            {
                for (int i = 1; i < SingletonCache.Instance.cantidadItereaciones; i++)
                {
                    if (continuar)
                    {
                        trampa = false;
                        if (i % 10 == 0)
                        {
                            trampa = true;
                        }
                        AlgoritmoGenetico.siguienteGeneracion(trampa);
                        SingletonCache.Instance.numGeneracion++;
                        updateStatistics();
                        if ((i - 1) % (SingletonCache.Instance.cantidadItereaciones / 10) == 0)
                        {
                            imagenesFinales.Add(SingletonCache.Instance.indMasAptoGen);
                            SingletonCache.agregarGeneracion();
                        }
                    }
                    else { break; }
                }
            }
            else {
                int boosts = (SingletonCache.Instance.cantidadItereaciones  / 5);

                for (int i = 1; i < SingletonCache.Instance.cantidadItereaciones; i++)
                {
                    if (continuar)
                    {
                        trampa = false;
                        if (i % boosts == 0)
                        {
                            trampa = true;
                        }
                        AlgoritmoGenetico.siguienteGeneracion(trampa);
                        SingletonCache.Instance.numGeneracion++;
                        updateStatistics();
                        if ((i - 1) % (SingletonCache.Instance.cantidadItereaciones / 10) == 0)
                        {
                            imagenesFinales.Add(SingletonCache.Instance.indMasAptoGen);
                            SingletonCache.agregarGeneracion();
                        }
                    }
                    else { break; }
                }
            
            
            }
            if (continuar)
            {
                Form2 muestraResultados = new Form2(this);
                singleton.imagenesFinales = imagenesFinales;
                muestraResultados.pictureBox1.Image = (imagenesFinales[0].image);
                muestraResultados.pictureBox2.Image = (imagenesFinales[1].image);
                muestraResultados.pictureBox3.Image = (imagenesFinales[2].image);
                muestraResultados.pictureBox4.Image = (imagenesFinales[3].image);
                muestraResultados.pictureBox5.Image = (imagenesFinales[4].image);
                muestraResultados.pictureBox6.Image = (imagenesFinales[5].image);
                muestraResultados.pictureBox7.Image = (imagenesFinales[6].image);
                muestraResultados.pictureBox8.Image = (imagenesFinales[7].image);
                muestraResultados.pictureBox9.Image = (imagenesFinales[8].image);
                muestraResultados.pictureBox10.Image = (imagenesFinales[9].image);
                muestraResultados.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("Se ha detenido el programa", "Detención manual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Restablecer();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Restablecer")){
               Restablecer();
            }
            else
            {
                continuar = false;
            }
        }
        public void Restablecer() {
            button1.Text = "Restablecer";
            pixel32.Checked = true;
            DistanciaManCheck.Checked = true;
            imagenObjetivo.Image = null;
            imagenGenerada.Image = null;
            histColorCheck.Checked = false;
            histFormaCheck.Checked = false;
            conTrampaCheck.Checked = false;
            // update current gen stats
            lblGenNumber.Text = "Generación #";
            indMasAptoGen.Text = "Individuo más apto: ";
            indPromedioGen.Text = "Individuo promedio: ";
            indMenosGen.Text = "Individuo menos apto: ";

            // update historic stats
            indMasHistor.Text = "Individuo más apto: ";
            indPromedioHistor.Text = "Individuo promedio: ";
            indMenosHistor.Text = "Individuo menos apto: ";
            entryCruces.Text = string.Empty;
            entryIteraciones.Text = string.Empty;
            entryMenosApt.Text = string.Empty;
            entryMutacion.Text = string.Empty;
            entryPoblacion.Text = string.Empty;
            continuar = true;
        }
    }
}
