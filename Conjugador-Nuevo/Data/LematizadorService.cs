using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conjugador_Nuevo.Data
{
    public class LematizadorService
    {
        public LematizadorResponse GetLematizadorResponse(string key, string lang = "es", Boolean multiPref = false)
        {
            ServicioLematizador.LematizadorSoapClient lematizador = new ServicioLematizador.LematizadorSoapClient(ServicioLematizador.LematizadorSoapClient.EndpointConfiguration.LematizadorSoap);

            ServicioLematizador.ArrayOfAnyType soapResponse = lematizador.ReconocerVerboAsync(key, lang, multiPref).Result.Body.ReconocerVerboResult;
            Object[] responseResult = soapResponse.First() as Object[];
            LematizadorResponse response = new LematizadorResponse(
                prefijo: responseResult[0].ToString(), 
                claveCanonica: Convert.ToInt32(responseResult[1]), 
                codigoFlexion: Convert.ToInt32(responseResult[2]),
                frecuencia: Convert.ToInt32(responseResult[3]), 
                infinitivo: responseResult[4].ToString(), 
                pronombreenclitico: responseResult[5].ToString()
            );

            return response;
        }
    }
}
