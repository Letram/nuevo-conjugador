using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using ConexionLematizador;

namespace Conjugador_Blazor.Data
{
    public class ReconocimientoComparer : IEqualityComparer<Reconocimiento>
    {
        public bool Equals([AllowNull] Reconocimiento x, [AllowNull] Reconocimiento y)
        {
            return x.IdFormaCanonica == y.IdFormaCanonica && x.IdFlexion == y.IdFlexion;
        }

        public int GetHashCode([DisallowNull] Reconocimiento obj)
        {
            return obj.GetHashCode();
        }
    }
}
