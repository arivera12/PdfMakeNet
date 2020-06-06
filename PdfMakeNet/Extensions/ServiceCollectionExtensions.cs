using Microsoft.Extensions.DependencyInjection;

namespace PdfMakeNet
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers the PdfMakeNet service to the service collection.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddPdfMakeNet(this IServiceCollection services)
        {
            return services.AddTransient<IPdfMake, PdfMake>();
        }
    }
}
