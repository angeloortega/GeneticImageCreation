using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Progra_1_Analisis
{
    class Utils
    {
        public static Bitmap generarImagenAleatoria(int cantidad) {
            //random number
            Random rand = new Random();
            int width = 16, height = 16;
            Bitmap bmp = new Bitmap(width, height);
            while (cantidad > 0)
            {

                //create random pixels
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //generate random ARGB value
                        int a = 255;
                        int r = rand.Next(256);
                        int g = rand.Next(256);
                        int b = rand.Next(256);

                        //set ARGB value
                        bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                

                bmp.Save("C:\\Users\\Angelo PC\\Desktop\\unPichazoDeImagenes\\imagen" +cantidad + ".png", ImageFormat.Png);
                cantidad--;
            }
            return bmp;
        }
    }
}
