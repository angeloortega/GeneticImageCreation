
using System.Collections.Generic;
using Progra_1_Analisis.Model;
namespace Progra_1_Analisis.Utilities
{
    public class SingletonCache
    {
        private static SingletonCache instance;
        public Imagen objetivo;
        public List<Imagen> poblacion;
        public List<Imagen> imagenesFinales;
        public int tamPoblacion;
        public int numGeneracion = 0;
        public int cantidadItereaciones;
        public double porcMutacion;
        public double porcCruses;
        public double porcMenosApt;
        public Imagen indMasAptoGen;
        public Imagen indMenosAptoGen;
        public double indPromedioAptoGen;
        public Imagen indMasAptoHist;
        public Imagen indMenosAptoHist;
        public double indPromedioAptoHist;
        public bool histColorChecked;
        public bool histFormaChecked;
        public bool DistGChecked;
        public bool DistManChecked;
        public bool trampa;
        private SingletonCache() { }

        public static SingletonCache Instance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonCache ();
                return instance;
            }
        }
        public static double getDiferenciaPromedio() {
            double diferencia = 0;
            foreach (Imagen rndmImg in Instance.poblacion)
            {
                diferencia += rndmImg.diferencia;
            }
            if (Instance.numGeneracion < 1)
            {
                Instance.indPromedioAptoHist = diferencia / Instance.tamPoblacion;
            }
            else {
                Instance.indPromedioAptoHist = (Instance.indPromedioAptoHist*Instance.numGeneracion + (diferencia / Instance.tamPoblacion))/(Instance.numGeneracion+1);
            }
            return diferencia / Instance.tamPoblacion;
        }
        //instance methods
        public static void calcularDiferencias()
        {
            foreach (Imagen rndmImg in Instance.poblacion)
            {
                rndmImg.calcularDiferencia(Instance.objetivo);
            }
            Instance.poblacion.Sort();
            if (Instance.numGeneracion < 1)
            {
                Instance.indMenosAptoHist = Instance.poblacion[Instance.tamPoblacion - 1];
                Instance.indMasAptoHist = Instance.poblacion[0];
            }
        }
    }
}
