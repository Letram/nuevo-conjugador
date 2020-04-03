using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConexionConjugador;

namespace Conjugador_Blazor.Data
{
    public class ConjugacionVerbo
    {
        public string[] nombreConjugacion { get; set; }
        public List<InfoConjugacion> conjEsp { get; set; }
        public List<InfoConjugacion> conjVos { get; set; }
        public List<InfoConjugacion> conjCan { get; set; }
        public List<InfoConjugacion> conjFor { get; set; }
    }
}