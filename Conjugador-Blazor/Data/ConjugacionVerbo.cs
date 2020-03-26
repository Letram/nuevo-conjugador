using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conjugador_Blazor.Data
{
    public class ConjugacionVerbo
    {
        public string[] nombreConjugacion { get; set; }
        public List<string> conjEsp { get; set; }
        public string conjVos { get; set; }
        public List<string> conjCan { get; set; }
        public List<string> conjFor { get; set; }
    }
}