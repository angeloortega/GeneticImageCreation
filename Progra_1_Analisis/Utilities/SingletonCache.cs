using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progra_1_Analisis.Model;
namespace Progra_1_Analisis.Utilities
{
    public class SingletonCache
    {
        private static SingletonCache instance;
        public Imagen objetivo;
        public List<Imagen> poblacion;
       
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

        //instance methods
        public static void calcularDiferencias()
        {
            foreach (Imagen rndmImg in Instance.poblacion)
            {
                rndmImg.calcularDiferencia(Instance.objetivo);
            }
            Instance.poblacion.Sort();
        }
    }
}
