using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Progra_1_Analisis.Model
{
    public class Imagen
    {
        public string id;
        double[] histogramaR;
        double[] histogramaG;
        double[] histogramaB;
        double[] histogramaA;
        public double diferencia;
        public double suma;
        public Imagen(string name, Bitmap bmp)
        {
            int height = bmp.Height;
            int width = bmp.Width;
            int aValue;
            int rValue;
            int gValue;
            int bValue;
            id = name;
            histogramaR = new double[256];
            histogramaG = new double[256];
            histogramaB = new double[256];
            histogramaA = new double[256];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    aValue = bmp.GetPixel(x, y).A;
                    rValue = bmp.GetPixel(x, y).R;
                    gValue = bmp.GetPixel(x, y).G;
                    bValue = bmp.GetPixel(x, y).B;
                    histogramaA[aValue]++;
                    histogramaR[rValue]++;
                    histogramaG[gValue]++;
                    histogramaB[bValue]++;
                }
            }
            //Normalizing so histograms can be comparable
            int tam = height * width;
            for (int j = 0; j < 256; j++)
            {
                histogramaA[j] = (histogramaA[j] / tam) * 100;
                histogramaR[j] = (histogramaR[j] / tam) * 100;
                histogramaG[j] = (histogramaG[j] / tam) * 100;
                histogramaB[j] = (histogramaB[j] / tam) * 100;
                suma += histogramaA[j] + histogramaR[j] + histogramaG[j] + histogramaB[j];
            }
        }
        public void distanciaManhattan(Imagen objetivo)
        {
            diferencia = 0;
            for (int i = 0; i < 256; i++) {
                diferencia += Math.Abs(histogramaA[i] - objetivo.histogramaA[i]) + Math.Abs(histogramaR[i] - objetivo.histogramaR[i]) + Math.Abs(histogramaG[i] - objetivo.histogramaG[i]) + Math.Abs(histogramaB[i] - objetivo.histogramaB[i]);
            }
        }
    }
}

