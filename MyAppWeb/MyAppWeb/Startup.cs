using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MyAppWeb
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config.json", optional:true, reloadOnChange:true);

            _configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var sqlConnection = _configuration.GetConnectionString("MyWebAppDb");
            services.AddDbContext<MyWebAppContext>(options =>
                options.UseMySql(sqlConnection, b => b.MigrationsAssembly("MyAppWeb")));

            services.AddMvc();
            services.AddScoped < IProdutoRepository, ProdutoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //app.Run(async (context) => { await context.Response.WriteAsync("Hello World!"); });
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}