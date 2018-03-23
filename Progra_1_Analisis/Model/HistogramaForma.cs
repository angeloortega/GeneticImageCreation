using System;
using System.Drawing;

namespace Progra_1_Analisis.Model
{
    public class HistogramaForma : Histograma
    {
        bool[] booleanMap;
        public HistogramaForma(Bitmap bmp) {
            booleanMap = new bool[1024];
            bool isPixelBright;
            Bitmap smallBit = Utilities.Utils.resizeImage(32, 32, bmp);

            for (int j = 0; j < 32; j++)
            {
                for (int i = 0; i < 32; i++)
                {
                    isPixelBright = (smallBit.GetPixel(i, j).GetBrightness() < 0.5f);
                    if (isPixelBright)
                    {
                        booleanMap[i + 32 * j] = true;
                    }
                }
            }
        }
        override
        public double distanciaManhattan(Imagen histograma)
        {
            HistogramaForma objetivo = histograma.histForma;
            double diferencia = 0;
            for (int i = 0; i < 1024; i++)
            {
                if (booleanMap[i] != objetivo.booleanMap[i])
                {
                    diferencia++;
                }
            }
            return (diferencia / (1024))* 100;
        }

        public double distanciaO(Imagen histograma)
        {
            HistogramaForma objetivo = histograma.histForma;
            double diferencia = 0;
            for (int i = 0; i < 1024; i++)
            {
                if (booleanMap[i] != objetivo.booleanMap[i])
                {
                    diferencia++;
                }
            }
            diferencia = Math.Sqrt(diferencia) * 100 / 32;
            return diferencia;
        }
    }
}
