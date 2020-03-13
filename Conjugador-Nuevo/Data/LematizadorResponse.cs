using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conjugador_Nuevo.Data
{
    public class LematizadorResponse
    {
        private string prefijo;
        private int claveCanonica;
        private int codigoFlexion;
        private int frecuencia;
        private string infinitivo;
        private string pronombreenclitico;

        public LematizadorResponse(string prefijo, int claveCanonica, int codigoFlexion, int frecuencia, string infinitivo, string pronombreenclitico)
        {
            this.Prefijo = prefijo;
            this.ClaveCanonica = claveCanonica;
            this.CodigoFlexion = codigoFlexion;
            this.Frecuencia = frecuencia;
            this.Infinitivo = infinitivo;
            this.Pronombreenclitico = pronombreenclitico;
        }

        public string Prefijo { get => prefijo; set => prefijo = value; }
        public int ClaveCanonica { get => claveCanonica; set => claveCanonica = value; }
        public int CodigoFlexion { get => codigoFlexion; set => codigoFlexion = value; }
        public int Frecuencia { get => frecuencia; set => frecuencia = value; }
        public string Infinitivo { get => infinitivo; set => infinitivo = value; }
        public string Pronombreenclitico { get => pronombreenclitico; set => pronombreenclitico = value; }

        public override string ToString()
        {
            return string.Format("Prefijo: {0} \n clave canónica: {1} \n código de flexión: {2} \n frecuencia: {3} \n infinitivo: {4} \n pronombre enclítico: {5}", prefijo, claveCanonica, codigoFlexion, frecuencia, infinitivo, pronombreenclitico);
        }
    }
}
