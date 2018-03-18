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
    public static class Cruce
    {
        public static Imagen cruceGenetico(Imagen padre1, Imagen padre2)
        {
            List<Imagen> opciones = new List<Imagen>(2);
            Imagen objetivo = SingletonCache.Instance.objetivo;
            Imagen opcion1;
            Imagen opcion2;
            Imagen opcion3;
            Imagen opcion4;
            Imagen opcion5;
            Imagen opcion6;
            Color padre2Color;
            Color padre2ColorRand;
            Color padre1ColorRand;
            Random rand = new Random();
            int width = padre1.image.Width;
            int height = padre1.image.Height;
            Bitmap bmpO1;
            Bitmap bmpO2;
            Bitmap bmpO3;
            Bitmap bmpO4;
            Bitmap bmpO5;
            Bitmap bmpO6;
            int p1R;
            int p1G;
            int p1B;
            int p2R;
            int p2G;
            int p2B;
            int randX;
            int randY;
            int x;
            int y;
            bmpO1 = new Bitmap(padre1.image);
            bmpO2 = new Bitmap(padre2.image);
            bmpO3 = new Bitmap(padre1.image);
            bmpO4 = new Bitmap(padre2.image);
            bmpO5 = new Bitmap(padre2.image);
            bmpO6 = new Bitmap(padre1.image);
            for (y = 0; y < height; y += 2)
            {
                for (x = 0; x < width; x += 2)
                {
                    randX = rand.Next(width);
                    randY = rand.Next(height);
                    padre2Color = padre2.image.GetPixel(x, y);
                    padre2ColorRand = padre2.image.GetPixel(randX, randY);
                    padre1ColorRand = padre1.image.GetPixel(randX, randY);
                    p1R = padre1ColorRand.R;
                    p1G = padre1ColorRand.G;
                    p1B = padre1ColorRand.B;
                    p2R = padre1ColorRand.R;
                    p2G = padre1ColorRand.G;
                    p2B = padre1ColorRand.B;
                    bmpO1.SetPixel(randX, randY, padre2Color);
                    bmpO2.SetPixel(randX, randY, Color.FromArgb((p1R + p2R) / 2, (p1G + p2G) / 2, (p1B + p2B) / 2));
                    bmpO3.SetPixel(randX, randY, padre2ColorRand);
                    bmpO4.SetPixel(x, y, padre2ColorRand);
                    bmpO5.SetPixel(randX, randY, Color.FromArgb((p1R + p2R) / 2, (p1G + p2G) / 2, (p1B + p2B) / 2));
                    bmpO6.SetPixel(x, y, Color.FromArgb((p1R + p2R * 2) / 3, (p1G + p2G * 2) / 3, (p1B + p2B * 2) / 3));
                }
            }
            opcion6 = new Imagen("op6", bmpO6);
            opcion5 = new Imagen("op5", bmpO5);
            opcion4 = new Imagen("op4", bmpO4);
            opcion3 = new Imagen("op3", bmpO3);
            opcion2 = new Imagen("op2", bmpO2);
            opcion1 = new Imagen("op1", bmpO1);
            opcion6.calcularDiferencia(objetivo);
            opcion5.calcularDiferencia(objetivo);
            opcion4.calcularDiferencia(objetivo);
            opcion3.calcularDiferencia(objetivo);
            opcion2.calcularDiferencia(objetivo);
            opcion1.calcularDiferencia(objetivo);
            opciones.Add(opcion6);
            opciones.Add(opcion5);
            opciones.Add(opcion4);
            opciones.Add(opcion3);
            opciones.Add(opcion2);
            opciones.Add(opcion1);
            opciones.Sort();
            if (rand.Next(100) < 5)
            {
                return opciones[5];
            }
            if (rand.Next(100) < 33)
            {
                return opciones[rand.Next(5)];
            }
            return opciones[0];
        }
        public static Imagen cruceCompObjetivo(Imagen padre1, Imagen padre2, Imagen objetivo)
        {
            Bitmap imagenFinal = new Bitmap(padre1.image.Height, padre1.image.Height);

            for (int y = 0; y < padre1.image.Height; y++)
            {
                for (int x = 0; x < padre1.image.Width; x++)
                {
                    imagenFinal.SetPixel(x, y, compararPixeles(padre1.image.GetPixel(x, y), padre2.image.GetPixel(x, y), objetivo.image.GetPixel(x, y)));
                }
            }
            return new Imagen("cruceComp", imagenFinal);
        }
        public static Color compararPixeles(Color p1, Color p2, Color pO)
        {
            double diferencia1 = Math.Abs(p1.R - pO.R) + Math.Abs(p1.G - pO.G) + Math.Abs(p1.B - pO.B);
            double diferencia2 = Math.Abs(p2.R - pO.R) + Math.Abs(p2.G - pO.G) + Math.Abs(p2.B - pO.B);
            if (diferencia1 < diferencia2)
            {
                return p1;
            }
            return p2;
        }

    }
}
