using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ConexionConjugador;
using ConexionCorrector;
using ConexionLematizador;

namespace Conjugador_Blazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            using (var conjugador = new ServicioConjugacionClient(ServicioConjugacionClient.EndpointConfiguration.BasicHttpsBinding_IServicioConjugacion))
            {
                using (var lematizador = new ServicioLematizacionClient(ServicioLematizacionClient.EndpointConfiguration.BasicHttpsBinding_IServicioLematizacion))
                {
                    using (var corrector = new ServicioSpellerClient(ServicioSpellerClient.EndpointConfiguration.BasicHttpsBinding_IServicioSpeller))
                    {
                        ThreadPool.QueueUserWorkItem(
                        new WaitCallback(delegate
                        {
                            while (true)
                            {
                                Thread.Sleep(TimeSpan.FromSeconds(100));
                                QueueDummyIOCPWork();
                            }
                        }));

                        conjugador.OpenAsync();
                        lematizador.OpenAsync();
                        corrector.OpenAsync();

                        Console.WriteLine("Service running...");
                        Console.ReadKey(false);
                    }
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //solucion de https://stackoverflow.com/questions/33389896/c-sharp-wcf-hosted-in-windows-service-goes-idle-after-5-minutes/33396091#33396091
        private static unsafe void QueueDummyIOCPWork()
        {
            Overlapped ovl = new Overlapped();
            NativeOverlapped* pOvl = null;
            pOvl = ovl.Pack((a, b, c) => { Overlapped.Unpack(pOvl); Overlapped.Free(pOvl); }, null);
            ThreadPool.UnsafeQueueNativeOverlapped(pOvl);
        }
    }
}
