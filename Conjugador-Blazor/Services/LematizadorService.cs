using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConexionLematizador;
namespace Conjugador_Blazor.Services
{
    public class LematizadorService
    {
        public async Task<List<Reconocimiento>> GetReconocimientosAsync(string verb, string lang = "es", bool multiPref = false)
        {

            List<Reconocimiento> reconocimiento = new List<Reconocimiento>();
            if ((await IsVerbAsync(verb)) == true)
            {
                ServicioLematizacionClient client = new ServicioLematizacionClient(ServicioLematizacionClient.EndpointConfiguration.BasicHttpsBinding_IServicioLematizacion);
                reconocimiento = await client.ReconocerVerboAsync(verb, lang, multiPref);
                await client.CloseAsync();
            }
            return reconocimiento;
        }

        public async Task<InfoCanonica> GetInfoCanonicaAsync(int idFormaCanonica)
        {
            ServicioLematizacionClient client = new ServicioLematizacionClient(ServicioLematizacionClient.EndpointConfiguration.BasicHttpsBinding_IServicioLematizacion);

            InfoCanonica infoCanonica = await client.ConsultaCanonicaAsync(idFormaCanonica);

            await client.CloseAsync();
            return infoCanonica;
        }

        public async Task<bool> IsVerbAsync(string verb)
        {
            ServicioLematizacionClient client = new ServicioLematizacionClient(ServicioLematizacionClient.EndpointConfiguration.BasicHttpsBinding_IServicioLematizacion);

            bool isVerb = await client.EsVerboAsync(verb);

            await client.CloseAsync();
            return isVerb;
        }
    }
}
