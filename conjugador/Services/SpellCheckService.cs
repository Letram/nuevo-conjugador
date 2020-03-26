using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConexionSpellChecker;

namespace conjugador.Services
{
    public class SpellCheckService
    {
        public async Task<string[]> GetSugerenciasAsync(string verb)
        {
            SpellerServiceClient client = new SpellerServiceClient(SpellerServiceClient.EndpointConfiguration.BasicHttpsBinding_ISpellerService);

            string[] sugerencias = await client.SugerenciasAsync(verb, true);

            await client.CloseAsync();

            return sugerencias;
        }

        public async Task<string[]> GetSimilaresAsync(string verb)
        {
            SpellerServiceClient client = new SpellerServiceClient(SpellerServiceClient.EndpointConfiguration.BasicHttpsBinding_ISpellerService);

            string[] similitudes = await client.SimilaresAsync(verb);

            await client.CloseAsync();

            return similitudes;
        }
    }
}
