using Progra_1_Analisis.Model;
using Progra_1_Analisis.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_1_Analisis.Logic
{
    public static class Mutacion
    {

        public static Imagen MutacionGenetica(Imagen padre, int pixelesPorMutar)
        {
            Bitmap bmp = padre.image;
            Random rand = new Random();
            int width = bmp.Width;
            int height = bmp.Height;
            pixelesPorMutar = (pixelesPorMutar / 100) * (width * height);
            int r;
            int g;
            int b;
            int newR;
            int newG;
            int newB;
            int x;
            int y;
            int newAclarar;
            Color oldColor;
            while (pixelesPorMutar > 0)
            {

                x = rand.Next(width);
                y = rand.Next(height);
                oldColor = bmp.GetPixel(x, y);
                r = oldColor.R;
                g = oldColor.G;
                b = oldColor.B;
                newR = rand.Next(256);
                newG = rand.Next(256);
                newB = rand.Next(256);
                newAclarar = rand.Next(50);
                if (rand.Next(100) < 50)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
                else
                {
                    if (rand.Next(100) < 30)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(Math.Abs(r - newAclarar) % 256, Math.Abs(g - newAclarar) % 256, Math.Abs(b - newAclarar) % 256));
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.FromArgb((r + newR) % 256, (g + newG) % 256, (b + newB) % 256));
                    }
                }
                pixelesPorMutar--;
            }
            padre.image = bmp;
            return padre;
        }

    }
}
