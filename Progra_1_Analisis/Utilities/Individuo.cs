
using CsvHelper.Configuration;

namespace Progra_1_Analisis.Model
{
    public class Individuo
    {
        public int numeroGeneracion { get; set; }
        public double adaptabilidad { get; set; }
    }
    public sealed class IndividuoMap : ClassMap<Individuo>
    {
        public IndividuoMap()
        {
            Map(m => m.numeroGeneracion).Name("NumeroGen::Generacion");
            Map(m => m.adaptabilidad).Name("Adaptabilidad::NumeroAdaptabilidad");
        }
    }
}
