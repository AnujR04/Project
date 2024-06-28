using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project.MyProject.BLL;
using Project.MyProject.DAL;
using Project.ProjectService;

namespace Project
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISalesService, SalesService>();
        }
    }
}
