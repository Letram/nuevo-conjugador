using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConexionConjugador;

namespace Conjugador_Blazor.Data
{
    public class NotaComparer : IEqualityComparer<Nota>
    {
        public bool Equals(Nota x, Nota y)
        {
            return x.IdNota == y.IdNota;
        }

        // If Equals() returns true for a pair of objects 
        // then GetHashCode() must return the same value for these objects.

        public int GetHashCode(Nota nota)
        {
            return nota.GetHashCode();
        }
    }
}
