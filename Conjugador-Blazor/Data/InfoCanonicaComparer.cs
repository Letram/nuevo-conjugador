using ConexionLematizador;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Conjugador_Blazor.Data
{
    public class InfoCanonicaComparer : IEqualityComparer<InfoCanonica>
    {
        public bool Equals([AllowNull] InfoCanonica x, [AllowNull] InfoCanonica y)
        {
            return x.FormaCanonica.Equals(y.FormaCanonica) && x.IdCategoria == y.IdCategoria && x.IdCategoriaGN == y.IdCategoriaGN && x.IdFlexion == y.IdFlexion;
        }

        public int GetHashCode([DisallowNull] InfoCanonica obj)
        {
            return obj.FormaCanonica.GetHashCode();
        }
    }
}
