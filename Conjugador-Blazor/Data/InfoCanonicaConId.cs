using ConexionLematizador;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Conjugador_Blazor.Data
{
    public class InfoCanonicaConId: IEqualityComparer<InfoCanonicaConId>
    {
        public InfoCanonica infoCanonica;
        public int idFormaCanonica;

        public InfoCanonicaConId(int id, InfoCanonica info)
        {
            this.idFormaCanonica = id;
            this.infoCanonica = info;
        }

        public bool Equals([AllowNull] InfoCanonicaConId x, [AllowNull] InfoCanonicaConId y)
        {
            return x.idFormaCanonica == y.idFormaCanonica;
        }

        public int GetHashCode([DisallowNull] InfoCanonicaConId obj)
        {
            return obj.GetHashCode();
        }
    }
}
