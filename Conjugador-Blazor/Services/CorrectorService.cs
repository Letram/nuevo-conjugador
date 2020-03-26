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
            SpellerServiceClient client = new SpellerServiceClient(SpellerServiceClient.EndpointConfiguration.BasicHttpsBinding_ISpellerService);

            List<string> sugerencias = await client.SugerenciasAsync(verb, true);

            await client.CloseAsync();

            return sugerencias;
        }

        public async Task<List<string>> GetSimilaresAsync(string verb)
        {
            SpellerServiceClient client = new SpellerServiceClient(SpellerServiceClient.EndpointConfiguration.BasicHttpsBinding_ISpellerService);

            List<string> similitudes = await client.SimilaresAsync(verb);

            await client.CloseAsync();

            return similitudes;
        }
    }
}
