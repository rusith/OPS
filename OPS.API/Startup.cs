using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OPS.API.Injection;
using OPS.Injection;

namespace OPS.API
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
      var bootstrappers = new List<IModuleBootstrapper> {
        new OPS.BL.Bootstrapper(),
        new OPS.DAL.Bootstrapper()
      };
      var dependencyStore = new DependencyStore(services);

      foreach (var bootstrapper in bootstrappers)
      {
        foreach (var module in bootstrapper.GetModules())
        {
          module.Bootstrap(dependencyStore);
        }
      }
      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseMvc();
    }
  }
}
