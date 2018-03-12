using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progra_1_Analisis.Model;
using Progra_1_Analisis.Utilities;
namespace Progra_1_Analisis.Logic
{
    public static class AlgoritmoGenetico
    {
        public static Imagen mutacion(Imagen padre, int pixelesPorMutar) {
            Bitmap bmp = padre.image;
            Random rand = new Random();
            int width = bmp.Width;
            int height = bmp.Height;
            pixelesPorMutar = (pixelesPorMutar / 100) * (width * height);
            int r;
            int g;
            int b;
            int newR;
            int newG;
            int newB;
            int x;
            int y;
            int newAclarar;
            Color oldColor;
            bool isNotPng = !SingletonCache.Instance.objetivo.id.Contains("png");
            while (pixelesPorMutar > 0) {
                
                x = rand.Next(width);
                y = rand.Next(height);
                oldColor = bmp.GetPixel(x,y);
                r = oldColor.R;
                g = oldColor.G;
                b = oldColor.B;
                newR = rand.Next(256);
                newG = rand.Next(256);
                newB = rand.Next(256);
                newAclarar = rand.Next(50);
                if (rand.Next(100) < 50)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
                else {
                    if (rand.Next(100) < 30) {
                        bmp.SetPixel(x, y, Color.FromArgb(Math.Abs(r - newAclarar) % 256, Math.Abs(g - newAclarar) % 256, Math.Abs(b - newAclarar) % 256));
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.FromArgb((r + newR) % 256, (g + newG) % 256, (b + newB) % 256));
                    }
                }
                pixelesPorMutar--;
            }
            padre.image = bmp;
            return padre;
        }
        public static Imagen cruceGenetico(Imagen padre1, Imagen padre2) {
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
            for (y = 0; y < height; y +=2)
            {
                for (x = 0; x < width; x +=2)
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
                    bmpO6.SetPixel(x, y, Color.FromArgb((p1R + p2R*2) / 3, (p1G + p2G*2) / 3, (p1B + p2B*2) / 3));
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
            if(rand.Next(100) < 5) {
                return opciones[5];
            }
            if (rand.Next(100) < 33) {
                return opciones[rand.Next(5)];
                    }
            return opciones[0];
        }
        public static Imagen cruceCompObjetivo(Imagen padre1, Imagen padre2, Imagen objetivo) {
            Bitmap imagenFinal = new Bitmap(padre1.image.Height, padre1.image.Height);

            for (int y = 0; y < padre1.image.Height; y++) {
                for (int x = 0; x < padre1.image.Width; x++)
                {
                    imagenFinal.SetPixel(x,y,compararPixeles(padre1.image.GetPixel(x, y), padre2.image.GetPixel(x, y), objetivo.image.GetPixel(x, y)));
                }
            }
            return new Imagen("cruceComp", imagenFinal);
        }
        public static Color compararPixeles(Color p1, Color p2, Color pO)
        {
            double diferencia1 = Math.Abs(p1.R - pO.R) + Math.Abs(p1.G - pO.G) + Math.Abs(p1.B - pO.B);
            double diferencia2 = Math.Abs(p2.R - pO.R) + Math.Abs(p2.G - pO.G) + Math.Abs(p2.B - pO.B);
            if (diferencia1 < diferencia2) {
                return p1;
            }
            return p2;
        }
        public static void primeraGeneracion(int pixel)
        {
            SingletonCache singleton = SingletonCache.Instance;
            Utils.generarImagenAleatoria(singleton.tamPoblacion, pixel);
            SingletonCache.calcularDiferencias();
            singleton.indMasAptoGen = singleton.poblacion[0];
            singleton.indPromedioAptoGen = SingletonCache.getDiferenciaPromedio();
            singleton.indMenosAptoGen = singleton.poblacion[SingletonCache.Instance.tamPoblacion - 1];
            singleton.numGeneracion = 1;
        }
        public static void siguienteGeneracion(bool trampa)
        {
            Random rnd = new Random();
            SingletonCache singleton = SingletonCache.Instance;
            Imagen p1;
            Imagen p2;
            List<Imagen> poblacionAct = singleton.poblacion;
            int tamPoblacion = poblacionAct.Count;
            List<Imagen> poblacionCandidata = new List<Imagen>(tamPoblacion);
            List<Imagen> poblacionNueva = new List<Imagen>(tamPoblacion);
            int indPorMutar = (int) ((singleton.porcMutacion / 100) * tamPoblacion);
            int crucesPorRealizar = (int) ((singleton.porcCruses / 100) * tamPoblacion);
            int menosAptosPorMantener = (int) ((singleton.porcMenosApt / 100) * tamPoblacion);
            int masAptosPorMantener = (int)0.1 * tamPoblacion;
            int mutante = 0;
            int randomInd;
            List<Imagen> tournament = new List<Imagen>(5);
            //Guardar un porcentaje de los mas aptos
            
            foreach (Imagen menosApto in (poblacionAct.GetRange(tamPoblacion - (menosAptosPorMantener + 1), menosAptosPorMantener))) {
                poblacionNueva.Add(menosApto);
            }
            foreach (Imagen masApto in (poblacionAct.GetRange(0, masAptosPorMantener / 2)))
            {
                poblacionNueva.Add(masApto);
            }
            while (indPorMutar > 0) {
                mutante = rnd.Next(poblacionAct.Count-1);
                poblacionCandidata.Add(mutacion(poblacionAct[mutante], rnd.Next(5,50)));
                indPorMutar--;
            }

            //Cruces entre aptos
            while (crucesPorRealizar > (2*crucesPorRealizar)/3)
            {
                for (int i = 0; i < rnd.Next(1,poblacionAct.Count%5 +2); i++)
                {
                    randomInd = rnd.Next(poblacionAct.Count);
                    tournament.Add(poblacionAct[randomInd]);
                }
                tournament.Sort();
                p1 = tournament[0];
                tournament.Clear();
                for (int i = 0; i < rnd.Next(1, poblacionAct.Count % 5 + 2); i++)
                {
                    randomInd = rnd.Next(poblacionAct.Count);
                    tournament.Add(poblacionAct[randomInd]);
                }
                tournament.Sort();
                p2 = tournament[0];
                if (trampa) {
                    poblacionCandidata.Add(cruceCompObjetivo(p1, p2,singleton.objetivo));
                }
                else
                {
                    poblacionCandidata.Add(cruceGenetico(p1, p2));
                }
                crucesPorRealizar--;
                if (rnd.Next(1,3) %2 == 0) {
                    poblacionAct.Remove(p1);
                }
                else
                {
                    poblacionAct.Remove(p2);
                }
                
            }
            while (crucesPorRealizar > crucesPorRealizar / 3)
            {
                for (int i = 0; i < rnd.Next(1, poblacionAct.Count % 5 + 2); i++)
                {
                    randomInd = rnd.Next(poblacionAct.Count);
                    tournament.Add(poblacionAct[randomInd]);
                }
                tournament.Sort();
                p1 = tournament[0];
                tournament.Clear();

                randomInd = rnd.Next(poblacionAct.Count/2,poblacionAct.Count);
                p2 = poblacionAct[randomInd];
                if (trampa)
                {
                    poblacionCandidata.Add(cruceCompObjetivo(p1, p2, singleton.objetivo));
                }
                else
                {
                    poblacionCandidata.Add(cruceGenetico(p1, p2));
                }
                crucesPorRealizar--;
                if (rnd.Next(1, 3) % 2 == 0)
                {
                    poblacionAct.Remove(p1);
                }
                else
                {
                    poblacionAct.Remove(p2);
                }
                
            }
            while (crucesPorRealizar > 0)
            {
                randomInd = rnd.Next(poblacionAct.Count / 2, poblacionAct.Count);
                p1 = poblacionAct[randomInd];
                randomInd = rnd.Next(poblacionAct.Count / 2, poblacionAct.Count);
                p2 = poblacionAct[randomInd];
                if (trampa)
                {
                    poblacionCandidata.Add(cruceCompObjetivo(p1, p2, singleton.objetivo));
                }
                else
                {
                    poblacionCandidata.Add(cruceGenetico(p1, p2));
                }
                crucesPorRealizar--;
                if (rnd.Next(1, 3) % 2 == 0)
                {
                    poblacionAct.Remove(p1);
                }
                else
                {
                    poblacionAct.Remove(p2);
                }
            }
            poblacionCandidata.Sort();
            //Formar generacion nueva
            while (poblacionNueva.Count < tamPoblacion) {
                if (poblacionCandidata.Count > 0)
                {
                    randomInd = rnd.Next(poblacionCandidata.Count);
                    poblacionNueva.Add(poblacionCandidata[randomInd]);
                    poblacionCandidata.Remove(poblacionCandidata[randomInd]);
                }
                else {

                    poblacionNueva.Add(poblacionAct[0]);
                    poblacionCandidata.Remove(poblacionAct[0]);
                }
            }
            singleton.poblacion = poblacionNueva;
            SingletonCache.calcularDiferencias();
            singleton.indMasAptoGen = singleton.poblacion[0];
            singleton.indPromedioAptoGen = SingletonCache.getDiferenciaPromedio();
            singleton.indMenosAptoGen = singleton.poblacion[SingletonCache.Instance.tamPoblacion - 1];
        }
    }

    
}
