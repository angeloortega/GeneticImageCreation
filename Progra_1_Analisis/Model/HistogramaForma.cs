using System;
using System.Drawing;

namespace Progra_1_Analisis.Model
{
    public class HistogramaForma : Histograma
    {
        int[][] booleanMap;
        public HistogramaForma(Bitmap bmp) {
            booleanMap = new int[16][];
            int[] booleanSubMap;
            bool isPixelBright;
            Bitmap smallBit = Utilities.Utils.resizeImage(64, 64, bmp);
            Bitmap[] imageSectors = new Bitmap[16];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    imageSectors[i * 4 + j] = new Bitmap(16, 16);
                    Graphics graphics = Graphics.FromImage(imageSectors[i * 4 + j]);
                    graphics.DrawImage(smallBit, new Rectangle(0, 0, 16, 16), new Rectangle(i * 16, j * 16, 16, 16), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
            for (int k = 0; k < 16; k++)
            {
                smallBit = imageSectors[k];
                booleanSubMap = new int[256];
                for (int j = 0; j < 16; j++)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        isPixelBright = (smallBit.GetPixel(i, j).GetBrightness() < 0.5f);
                        if (isPixelBright)
                        {
                            booleanSubMap[i + 16 * j] += 1;
                        }
                    }
                }
                booleanMap[k] = booleanSubMap;
            }
        }
        override
        public double distanciaManhattan(Imagen histograma)
        {
            HistogramaForma objetivo = histograma.histForma;
            double diferencia = 0;
            for (int k = 0; k < 16; k++) {
                for (int i = 0; i < 256; i++)
                {
                    diferencia += Math.Abs(booleanMap[k][i] - objetivo.booleanMap[k][i]);
                }
            }
            return (diferencia / (256 * 16))* 100;
        }
    }
}
