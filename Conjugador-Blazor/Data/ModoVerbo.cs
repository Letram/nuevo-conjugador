using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conjugador_Blazor.Data
{
    public class ModoVerbo
    {
        public string modo { get; set; }
        public List<ConjugacionVerbo> conjugaciones { get; set; }

        public ModoVerbo(string modo, List<ConjugacionVerbo> conjugacionVerbos)
        {
            this.modo = modo;
            conjugaciones = conjugacionVerbos;
        }
    }
}
