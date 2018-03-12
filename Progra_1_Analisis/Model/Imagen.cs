using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Progra_1_Analisis.Utilities;

namespace Progra_1_Analisis.Model
{
    public class Imagen : IComparable<Imagen>
    {
        public string id;
        public Bitmap image;
        public HistogramaColor histColor;
        public HistogramaForma histForma;
        public double diferencia;
        public Imagen(string name, Bitmap bmp)
        {
            id = name;
            histColor = new HistogramaColor(bmp);
            histForma = new HistogramaForma(bmp);
            image = bmp;
        }
        public void calcularDiferencia(Imagen objetivo) {
            SingletonCache singleton = SingletonCache.Instance;
            if (singleton.histColorChecked && singleton.histFormaChecked)
            {
                if (singleton.DistGChecked)
                {
                }
                if (singleton.DistManChecked)
                {
                    diferencia = histColor.distanciaManhattan(objetivo);
                    diferencia += histForma.distanciaManhattan(objetivo)*2;

                    diferencia /= 3;
                }
                
            }
            else if (singleton.histColorChecked)
            {
                if (singleton.DistGChecked)
                {
                }
                if (singleton.DistManChecked)
                {
                    diferencia = histColor.distanciaManhattan(objetivo);
                }
            }
            else {
                if (singleton.DistGChecked)
                {
                }
                if (singleton.DistManChecked)
                {
                    diferencia = histForma.distanciaManhattan(objetivo);
                }
            }
        }

        public int CompareTo(Imagen other)
        {
            return diferencia.CompareTo(other.diferencia);
        }
    }
}

