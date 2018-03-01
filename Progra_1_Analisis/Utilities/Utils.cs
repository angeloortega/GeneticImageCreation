using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using Progra_1_Analisis.Model;
using System.Windows.Forms;

namespace Progra_1_Analisis.Utilities
{
    class Utils
    {
        public static Bitmap generarImagenAleatoria(int cantidad) {
            //random number
            Random rand = new Random();
            int width = 128, height = 128;
            Bitmap bmp = new Bitmap(width, height);
            SingletonCache singleton = SingletonCache.Instance;
            Imagen[] poblacion = new Imagen[cantidad];
            while (cantidad > 0)
            {

                //create random pixels
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //generate random ARGB value
                        int a = rand.Next(256);
                        int r = rand.Next(256);
                        int g = rand.Next(256);
                        int b = rand.Next(256);

                        //set ARGB value
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                poblacion[cantidad - 1] = new Imagen("imagen" + cantidad, bmp);
                bmp.Save("C:\\Users\\Angelo PC\\Desktop\\unPichazoDeImagenes\\imagen" +cantidad + ".png", ImageFormat.Png);
                cantidad--;
            }
            singleton.poblacion = poblacion;
            return bmp;
        }
        public static Bitmap cargarImagen()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(open.FileName);
                SingletonCache singleton = SingletonCache.Instance;
                singleton.objetivo = new Imagen("objetivo", bmp);
                // display image in picture box  
                return bmp;
            }
            return null;
        }
    }
}
