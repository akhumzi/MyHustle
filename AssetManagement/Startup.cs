using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AssetManagementServices;

namespace AssetManagement
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      services.AddSingleton(Configuration); 
      services.AddScoped<IAssetManagement, AssetService>() ;
      //  services.AddDbContext<AssetManagementContext>(options
      //    => options.UseSqlServer(Configuration.GetConnectionString("AssetConnection")));
      //}
      services.AddDbContext<AssetManagementContext>(options =>
      options.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AssetManagementDB_Dev;Data Source=DESKTOP-H1TKV61"));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseBrowserLink();
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
      }

      app.UseStaticFiles();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
                  name: "default",
                  template: "{controller=Home}/{action=Index}/{id?}");
      });
    }
  }
}
