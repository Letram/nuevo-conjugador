using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using ConexionLematizador;
namespace Conjugador_Blazor.Data
{
    public class ReconocimientoInfoCanonica: IEqualityComparer<ReconocimientoInfoCanonica>
    {
        public string Verbo { get; set; }
        public List<Reconocimiento> Reconocimientos { get; set; }
        public List<InfoCanonica> InfoCanonicas { get; set; }

        public ReconocimientoInfoCanonica()
        {
            Reconocimientos = new List<Reconocimiento>();
            InfoCanonicas = new List<InfoCanonica>();
        }

        public int GetIdCanonicaConjugacion()
        {
            return Reconocimientos.FirstOrDefault(rec => rec.IdFormaCanonica < 200000).IdFormaCanonica;
        }


        public bool Equals([AllowNull] ReconocimientoInfoCanonica x, [AllowNull] ReconocimientoInfoCanonica y)
        {
            return x.Verbo.Equals(y.Verbo);
        }

        public int GetHashCode([DisallowNull] ReconocimientoInfoCanonica obj)
        {
            return obj.Verbo.GetHashCode();
        }
    }
}
