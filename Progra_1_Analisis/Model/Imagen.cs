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
        string id;
        double[] histogramaR;
        double[] histogramaG;
        double[] histogramaB;
        double[] histogramaA;

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
            double prueba = 0.00;
            for (int j = 0; j < 256; j++)
            {
                histogramaA[j]= histogramaA[j]/tam;
                histogramaR[j]= histogramaR[j]/tam;
                histogramaG[j]= histogramaG[j]/tam;
                histogramaB[j]= histogramaB[j]/tam;
            }
        }
    }
}

