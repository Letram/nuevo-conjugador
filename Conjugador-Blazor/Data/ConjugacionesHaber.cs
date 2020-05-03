using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conjugador_Blazor.Data
{
    public class ConjugacionesHaber
    {
        public List<List<List<string>>> ConjugacionVerboHaber = new List<List<List<string>>>{
            new List<List<string>>{
                new List<string>{ "he" },     new List<string> { "has" },     new List<string> { "ha"},     new List<string> { "hemos"},     new List<string> { "habéis" },    new List<string> { "han" }
            },
            new List<List<string>>{
                new List<string>{ "habré" },  new List<string> { "habrá" },   new List<string> { "habrá"},  new List<string> { "habremos"},  new List<string> { "habréis" },   new List<string> { "habrán" }
            },
            new List<List<string>>{
                new List<string>{ "había" },  new List<string> { "habías" },  new List<string> { "había"},  new List<string> { "habíamos"},  new List<string> { "habíais" },   new List<string> { "habían" }
            },
            new List<List<string>>{
                new List<string>{ "habría" }, new List<string> { "habrías" }, new List<string> { "habría"}, new List<string> { "habríamos"}, new List<string> { "habríais" },  new List<string> { "habrían" }
            },
            new List<List<string>>{
                new List<string>{ "hube" },   new List<string> { "hubiste" }, new List<string> { "hubo"},   new List<string> { "hubimos"},   new List<string> { "hubisteis" }, new List<string> { "hubieron" }
            },
            new List<List<string>>{
                new List<string>{ "haya" },   new List<string> { "hayas" }, new List<string> { "haya"},   new List<string> { "hayamos"},   new List<string> { "hayais" }, new List<string> { "hayan" }
            },
            new List<List<string>>{
                new List<string>{ "hubiera", "hubiese" },   new List<string> { "hubieras", "hubieses" }, new List<string> { "hubiera", "hubiese"},   new List<string> { "hubiéramos", "hubiésemos"},   new List<string> { "hubiérais", "hubiéseis"}, new List<string> { "hubieran", "hubiesen" }
            },
            new List<List<string>>{
                new List<string>{ "hubiere" },   new List<string> { "hubieres" }, new List<string> { "hubiere"},   new List<string> { "hubiéremos"},   new List<string> { "hubiéreis" }, new List<string> { "hubieren" }
            }
        };
        public List<List<string>> NombresConjugacionesVerboHaber = new List<List<string>>
        {
            new List<string>{ "Preterito_perfecto_comp", "Antepresente"},
            new List<string>{ "Futuro_comp", "Antefuturo"},
            new List<string>{ "Preterito_pluscuamperfecto", "Antecopreterito"},
            new List<string>{ "Condicional_comp", "Antepospreterito"},
            new List<string>{ "Preterito_anterior", "Antepreterito"},
            new List<string>{ "Preterito_perfecto_comp", "Antepresente"},
            new List<string>{ "Preterito_pluscuamperfecto", "Antecopreterito"},
            new List<string>{ "Futuro_comp", "Antefuturo"},
        };
    }
}
