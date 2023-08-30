using test_naimul.IRepository;
using test_naimul.Repository;

namespace test_naimul
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IAuthentication, Authentication>();



        }
    }
}
