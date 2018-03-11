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
        public double[] histogramaR;
        public double[] histogramaG;
        public double[] histogramaB;
        public double[] histogramaA;
        public HistogramaColor(Bitmap bmp) {
            histogramaR = new double[64];
            histogramaG = new double[64];
            histogramaB = new double[64];
            int height = bmp.Height;
            int width = bmp.Width;
            int rValue;
            int gValue;
            int bValue;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
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
            //Normalizing so histograms can be comparable
            int tam = height * width;
            for (int j = 0; j < 64; j++)
            {
                histogramaR[j] = (histogramaR[j] / tam) * 100;
                histogramaG[j] = (histogramaG[j] / tam) * 100;
                histogramaB[j] = (histogramaB[j] / tam) * 100;
            }
        }
        override
        public double distanciaManhattan(Imagen histograma)
        {
            HistogramaColor objetivo = histograma.histColor;
            double diferencia = 0;
            for (int i = 0; i < 64; i++)
            {
                diferencia += Math.Abs(histogramaR[i] - objetivo.histogramaR[i]) + Math.Abs(histogramaG[i] - objetivo.histogramaG[i]) + Math.Abs(histogramaB[i] - objetivo.histogramaB[i]);
            }
            return diferencia / 6;
        }
    }
}
