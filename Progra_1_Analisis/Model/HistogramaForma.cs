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
            Bitmap smallBit = Utilities.Utils.resizeImage(32, 32, bmp);
            Bitmap[] imageSectors = new Bitmap[16];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    imageSectors[i * 4 + j] = new Bitmap(8, 8);
                    Graphics graphics = Graphics.FromImage(imageSectors[i * 4 + j]);
                    graphics.DrawImage(smallBit, new Rectangle(0, 0, 8, 8), new Rectangle(i * 8, j * 8, 8, 8), GraphicsUnit.Pixel);
                    graphics.Dispose();
                }
            }
            for (int k = 0; k < 16; k++)
            {
                smallBit = imageSectors[k];
                booleanSubMap = new int[64];
                for (int j = 0; j < 8; j++)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        isPixelBright = (smallBit.GetPixel(i, j).GetBrightness() < 0.5f);
                        if (isPixelBright)
                        {
                            booleanSubMap[i + 8 * j] += 1;
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
                for (int i = 0; i < 64; i++)
                {
                    diferencia += Math.Abs(booleanMap[k][i] - objetivo.booleanMap[k][i]);
                }
            }
            return (diferencia / (64 * 16))* 100;
        }

        public double distanciaGiullaMan(Imagen histograma)
        {
            HistogramaForma objetivo = histograma.histForma;
            double diferencia = 0;
            for (int k = 0; k < 16; k++)
            {
                for (int i = 0; i < 64; i++)
                {
                    if (booleanMap[k][i] != objetivo.booleanMap[k][i])
                    {
                        diferencia++;
                    }

                }
            }
            diferencia = Math.Sqrt(diferencia) * 100 / 32;
            return diferencia;
        }
    }
}
