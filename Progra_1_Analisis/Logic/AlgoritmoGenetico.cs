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
            int newcolor;
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
                newcolor = (int)(newR + newG + newB) / 3;
                if (rand.Next(100) < 30)
                {
                    bmp.SetPixel(x, y, Color.FromArgb((r + newcolor) % 256, (g + newcolor) % 256, (b + newcolor) % 256));
                }
                else {
                    if (rand.Next(100) % 2 == 0) {
                        bmp.SetPixel(x, y, Color.FromArgb(Math.Abs(r - newcolor) % 256, Math.Abs(g - newcolor) % 256, Math.Abs(b - newcolor) % 256));
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
            bmpO5 = new Bitmap(padre1.image);
            bmpO6 = new Bitmap(padre2.image);
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
            Console.WriteLine(opciones[0].id);
            if(rand.Next(100) < 5) {
                return opciones[5];
            }
            if (rand.Next(100) < 33) {
                return opciones[rand.Next(6)];
                    }
            return opciones[0];
        }
        public static void primeraGeneracion()
        {
            SingletonCache singleton = SingletonCache.Instance;
            Utils.generarImagenAleatoria(singleton.tamPoblacion);
            SingletonCache.calcularDiferencias();
            singleton.indMasAptoGen = singleton.poblacion[0];
            singleton.indPromedioAptoGen = SingletonCache.getDiferenciaPromedio();
            singleton.indMenosAptoGen = singleton.poblacion[SingletonCache.Instance.tamPoblacion - 1];
            singleton.numGeneracion = 1;
        }
        public static void siguienteGeneracion()
        {
            Random rnd = new Random();
            SingletonCache singleton = SingletonCache.Instance;
            Imagen p1;
            Imagen p2;
            List<Imagen> poblacionAct = singleton.poblacion;
            int tamPoblacion = poblacionAct.Count;
            List<Imagen> poblacionNueva = new List<Imagen>(tamPoblacion);
            int indPorMutar = (int) ((singleton.porcMutacion / 100) * tamPoblacion);
            int crucesPorRealizar = (int) ((singleton.porcCruses / 100) * tamPoblacion);
            int menosAptosPorMantener = (int) ((singleton.porcMenosApt / 100) * tamPoblacion);
            int generados = 0;
            int mutante = 0;
            int tamPoblacionFinal = tamPoblacion;
            List<Imagen> tournament = new List<Imagen>(5);
            //guardar al mas apto
            foreach (Imagen menosApto in (poblacionAct.GetRange(tamPoblacion - (menosAptosPorMantener + 1), menosAptosPorMantener))) {
                poblacionNueva.Add(menosApto);
                generados++;
            }
            while (indPorMutar > 0) {
                mutante = rnd.Next(tamPoblacion-1);
                poblacionNueva.Add(mutacion(poblacionAct[mutante], rnd.Next(15, 40)));
                generados++;
                indPorMutar--;
                tamPoblacion--;
                poblacionAct.Remove(poblacionAct[mutante]);
            }
            while (crucesPorRealizar > 0)
            {
                for (int i = 0; i < rnd.Next(1,tamPoblacion%5 +2); i++)
                {
                    int randomInd = rnd.Next(tamPoblacion);
                    tournament.Add(poblacionAct[randomInd]);
                }
                tournament.Sort();
                p1 = tournament[0];
                tournament.Clear();
                for (int i = 0; i < rnd.Next(1, tamPoblacion % 5 + 2); i++)
                {
                    int randomInd = rnd.Next(poblacionAct.Count);
                    tournament.Add(poblacionAct[randomInd]);
                }
                tournament.Sort();
                p2 = tournament[0];
                poblacionNueva.Add(cruceGenetico(p1,p2));
                generados++;
                crucesPorRealizar--;
                if (rnd.Next(1,3) %2 == 0) {
                    poblacionAct.Remove(p1);
                }
                else
                {
                    poblacionAct.Remove(p2);
                }
                tamPoblacion--;
            }
            while (generados < tamPoblacionFinal) {
                tournament.Clear();
                for (int i = 0; i < rnd.Next(1, tamPoblacion % 5 + 2); i++)
                {
                    int randomInd = rnd.Next(poblacionAct.Count);
                    tournament.Add(poblacionAct[randomInd]);
                }
                tournament.Sort();
                poblacionNueva.Add(tournament[0]);
                generados++;
            }
            singleton.poblacion = poblacionNueva;
            SingletonCache.calcularDiferencias();
            singleton.indMasAptoGen = singleton.poblacion[0];
            singleton.indPromedioAptoGen = SingletonCache.getDiferenciaPromedio();
            singleton.indMenosAptoGen = singleton.poblacion[SingletonCache.Instance.tamPoblacion - 1];
        }
    }

    
}
