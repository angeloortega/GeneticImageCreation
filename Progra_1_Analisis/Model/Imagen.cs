using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Progra_1_Analisis.Model
{
    public class Imagen : IComparable<Imagen>
    {
        public string id;
        private Bitmap image;
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
            diferencia = histColor.distanciaManhattan(objetivo) * 2;
            diferencia += histForma.distanciaManhattan(objetivo);
            diferencia /= 3;
        }

        public int CompareTo(Imagen other)
        {
            return diferencia.CompareTo(other.diferencia);
        }
    }
}

