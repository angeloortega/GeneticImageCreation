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
            int a;
            int r;
            int g;
            int b;
            int newA;
            int newR;
            int newG;
            int newB;
            int x;
            int y;
            Color oldColor;
            bool isNotPng = !SingletonCache.Instance.objetivo.id.Contains("png");
            while (pixelesPorMutar > 0) {
                
                x = rand.Next(width);
                y = rand.Next(height);
                oldColor = bmp.GetPixel(x,y);

                a = oldColor.A;
                r = oldColor.R;
                g = oldColor.G;
                b = oldColor.B;

                newA = rand.Next(256);
                if (isNotPng)
                {
                    newA = 255;
                }
                newR = rand.Next(256);
                newG = rand.Next(256);
                newB = rand.Next(256);
                bmp.SetPixel(x, y, Color.FromArgb( newA, newR,newG, newB));
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
            Color padre1Color;
            Color padre2Color;
            Color padre2ColorRand;

            Random rand = new Random();
            int width = padre1.image.Width;
            int height = padre1.image.Height;
            Bitmap bmpO1;
            Bitmap bmpO2;
            Bitmap bmpO3;
            Bitmap bmpO4;
            int p1A;
            int p1R;
            int p1G;
            int p1B;
            int p2A;
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
            for (y = 0; y < height; y += 2) {
                for(x = 0; x < width; x += 2)
                {
                    randX = rand.Next(width);
                    randY = rand.Next(height);
                    padre1Color = padre1.image.GetPixel(x, y);
                    padre2Color = padre2.image.GetPixel(x, y);
                    padre2ColorRand = padre2.image.GetPixel(randX, randY);
                    p1A = padre1Color.A;
                    p1R = padre1Color.R;
                    p1G = padre1Color.G;
                    p1B = padre1Color.B;
                    p2A = padre1Color.A;
                    p2R = padre1Color.R;
                    p2G = padre1Color.G;
                    p2B = padre1Color.B;
                    bmpO1.SetPixel(x, y, padre2Color);
                    bmpO2.SetPixel(randX, randY, padre2Color);
                    bmpO3.SetPixel(randX, randY, padre2ColorRand);
                    bmpO4.SetPixel(x, y, padre2ColorRand);
                }

            }
            opcion4 = new Imagen("op4", bmpO4);
            opcion3 = new Imagen("op3", bmpO3);
            opcion2 = new Imagen("op2", bmpO2);
            opcion1 = new Imagen("op1", bmpO1);
            opcion4.calcularDiferencia(objetivo);
            opcion3.calcularDiferencia(objetivo);
            opcion2.calcularDiferencia(objetivo);
            opcion1.calcularDiferencia(objetivo);
            opciones.Add(opcion4);
            opciones.Add(opcion3);
            opciones.Add(opcion2);
            opciones.Add(opcion1);
            opciones.Sort();
            Console.WriteLine(opciones[0].id);
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
            int tamPoblacion = singleton.tamPoblacion;
            Imagen p1;
            Imagen p2;
            List<Imagen> poblacionAct = singleton.poblacion;
            List<Imagen> poblacionNueva = new List<Imagen>(tamPoblacion);
            int indPorMutar = (int) ((singleton.porcMutacion / 100) * tamPoblacion);
            int crucesPorRealizar = (int) ((singleton.porcCruses / 100) * tamPoblacion);
            int menosAptosPorMantener = (int) ((singleton.porcMenosApt / 100) * tamPoblacion);
            int generados = 0;
            int padre1 = 0;
            int padre2 = 0;
            int mutante = 0;
            int tamPoblacionFinal = tamPoblacion;
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
                while(padre1 == padre2) {
                    padre1 = rnd.Next(tamPoblacion);
                    padre2 = rnd.Next(tamPoblacion);
                }
                while (padre1 >= tamPoblacion) {
                    padre1--;
                }
                while (padre2 >= tamPoblacion)
                {
                    padre2--;
                }
                if (rnd.Next(501) < 1) {
                    padre2 = tamPoblacion - 1;
                }
                if (rnd.Next(101) < 1)
                {
                    padre1 = 0;
                }
                p1 = poblacionAct[padre1];
                p2 = poblacionAct[padre2];
                poblacionNueva.Add(cruceGenetico(p1,p2));
                generados++;
                crucesPorRealizar--;
                if(rnd.Next(101) < 50)
                    poblacionAct.Remove(p1);
                else
                    poblacionAct.Remove(p2);
                tamPoblacion -= 1;
            }
            while (generados < tamPoblacionFinal) {
                poblacionNueva.Add(poblacionAct[rnd.Next((int)(tamPoblacion) /2)]);
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
