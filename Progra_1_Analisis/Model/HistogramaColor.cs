using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_1_Analisis.Model
{
    public class HistogramaColor : Histograma
    {
        public double[][][] sectoresDeHistograma;
        public double[][] histogramaRGB;
        public double[] histogramaR;
        public double[] histogramaG;
        public double[] histogramaB;

        public HistogramaColor(Bitmap bmp) {
            sectoresDeHistograma = new double[16][][];
            int height = 8;
            int width = 8;
            int rValue;
            int gValue;
            int bValue;
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
                histogramaRGB = new double[3][];
                histogramaR = new double[64];
                histogramaG = new double[64];
                histogramaB = new double[64];
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color pixel = smallBit.GetPixel(x, y);
                        rValue = pixel.R;
                        gValue = pixel.G;
                        bValue = pixel.B;
                        rValue = rValue / 4;
                        gValue = gValue / 4;
                        bValue = bValue / 4;
                        histogramaR[rValue]++;
                        histogramaG[gValue]++;
                        histogramaB[bValue]++;
                    }
                }
                histogramaRGB[0] = histogramaR;
                histogramaRGB[1] = histogramaG;
                histogramaRGB[2] = histogramaB;
                sectoresDeHistograma[k] = histogramaRGB;
            }
            
            //Normalizing so histograms can be comparable
            int tam = height * width;
            for (int k = 0; k < 16; k++)
            {
                for (int j = 0; j < 64; j++)
                {
                    
                    sectoresDeHistograma[k][0][j] = (sectoresDeHistograma[k][0][j] / tam) * 100;
                    sectoresDeHistograma[k][1][j] = (sectoresDeHistograma[k][1][j] / tam) * 100;
                    sectoresDeHistograma[k][2][j] = (sectoresDeHistograma[k][2][j] / tam) * 100;
                }
            }

            return;
        }
        override
        public double distanciaManhattan(Imagen histograma)
        {
            HistogramaColor objetivo = histograma.histColor;
            double diferenciaParcial = 0;
            double diferenciaFinal = 0;
            for (int k = 0; k < 16; k++)
            {
                diferenciaParcial = 0;
                    for (int i = 0; i < 64; i++)
                {
                    diferenciaParcial += Math.Abs(sectoresDeHistograma[k][0][i] - objetivo.sectoresDeHistograma[k][0][i]) + Math.Abs(sectoresDeHistograma[k][1][i] - objetivo.sectoresDeHistograma[k][1][i]) + Math.Abs(sectoresDeHistograma[k][2][i] - objetivo.sectoresDeHistograma[k][2][i]);
                }
                diferenciaFinal = diferenciaParcial / 6;
            }
            return diferenciaParcial / 16;
        }
    }
}
