using OficinaSimples.Infra.Data.Configurations;

namespace OficinaSimples.UI.Desktop.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices( this ServiceCollection services)
        {
            services.AddInfrastructureData(FileSystem.AppDataDirectory);
        }
    }
}
