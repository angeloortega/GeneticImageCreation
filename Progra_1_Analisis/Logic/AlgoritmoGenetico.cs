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
            
            poblacionAct.Sort();
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
                poblacionCandidata.Add(Mutacion.MutacionGenetica(poblacionAct[mutante], rnd.Next(5,50)));
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
                    poblacionCandidata.Add(Cruce.cruceCompObjetivo(p1, p2,singleton.objetivo));
                }
                else
                {
                    poblacionCandidata.Add(Cruce.cruceGenetico(p1, p2));
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
                    poblacionCandidata.Add(Cruce.cruceCompObjetivo(p1, p2, singleton.objetivo));
                }
                else
                {
                    poblacionCandidata.Add(Cruce.cruceGenetico(p1, p2));
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
                    poblacionCandidata.Add(Cruce.cruceCompObjetivo(p1, p2, singleton.objetivo));
                }
                else
                {
                    poblacionCandidata.Add(Cruce.cruceGenetico(p1, p2));
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
                    poblacionAct.Remove(poblacionAct[0]);
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
