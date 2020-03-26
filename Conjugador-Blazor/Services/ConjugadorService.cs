using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConexionConjugador;
namespace Conjugador_Blazor.Services
{
    public class ConjugadorService
    {

        public async Task<List<InfoConjugacion>> GetInfoConjugacion(int idFormaCanonica) {
            ServicioConjugacionClient client = new ServicioConjugacionClient(ServicioConjugacionClient.EndpointConfiguration.BasicHttpsBinding_IServicioConjugacion);

            List<InfoConjugacion> result = await client.ConsultaConjugacionAsync(idFormaCanonica);

            await client.CloseAsync();

            return result;
        }

    }
}
