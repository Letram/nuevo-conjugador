using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConexionCorrector;
namespace Conjugador_Blazor.Services
{
    public class CorrectorService
    {
        public async Task<List<string>> GetSugerenciasAsync(string verb)
        {
            ServicioSpellerClient client = new ServicioSpellerClient(ServicioSpellerClient.EndpointConfiguration.BasicHttpsBinding_IServicioSpeller);

            List<string> sugerencias = await client.SugerenciasAsync(verb, true);

            await client.CloseAsync();

            return sugerencias;
        }

        public async Task<List<string>> GetSimilaresAsync(string verb)
        {
            ServicioSpellerClient client = new ServicioSpellerClient(ServicioSpellerClient.EndpointConfiguration.BasicHttpsBinding_IServicioSpeller);

            List<string> similitudes = await client.SimilaresAsync(verb);

            await client.CloseAsync();

            return similitudes;
        }
    }
}
