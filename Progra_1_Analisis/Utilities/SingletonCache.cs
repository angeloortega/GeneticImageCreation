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
        public Imagen[] poblacion;
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
    }
}
