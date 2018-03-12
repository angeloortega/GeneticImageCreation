using Progra_1_Analisis.Model;
using Progra_1_Analisis.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra_1_Analisis
{
    public partial class Form2 : Form

    {
        private Form1 parent;
        public Form2(Form1 pParent)
        {
            InitializeComponent();
            parent = pParent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lblRuta.Text = fbd.SelectedPath;
                }
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (lblRuta.Text.Equals(string.Empty)) {
                MessageBox.Show("Por favor seleccione la ruta donde desea guardar la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string finalImage = lblRuta.Text + "\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".png";
            int nIndex = 0;
            int width = 0;
            List<Imagen> imagenesFinales = SingletonCache.Instance.imagenesFinales;
            foreach (Imagen img in imagenesFinales)
            {
                width += img.image.Width;
            }
            int height = imagenesFinales[0].image.Width;
            Bitmap img3 = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(img3);
            g.Clear(SystemColors.AppWorkspace);
            foreach (Imagen img in imagenesFinales)
            {
                if (nIndex == 0)
                {
                    g.DrawImage(img.image, new Point(0, 0));
                    nIndex++;
                    width = img.image.Width;
                }
                else
                {
                    g.DrawImage(img.image, new Point(width, 0));
                    width += img.image.Width;
                }
            }
          
            img3.Save(@finalImage, System.Drawing.Imaging.ImageFormat.Png);
            g.Dispose();
            img3.Dispose();
            MessageBox.Show("La imágen se guardó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            parent.Restablecer();
            parent.Visible = true;
            this.Close();
        }
    }
}
