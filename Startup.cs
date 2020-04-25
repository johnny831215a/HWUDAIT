using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace wk0801
{
  using Microsoft.AspNetCore.StaticFiles;
  using Microsoft.Extensions.FileProviders;
  using System.IO;
    public class Startup
    {

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          var provider = new FileExtensionContentTypeProvider();
// Add new mappings
provider.Mappings[".obj"] = "text/html";
provider.Mappings[".mtl"] = "text/html";
app.UseStaticFiles(new StaticFileOptions
{
FileProvider = new PhysicalFileProvider(
Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")),
RequestPath = "",
ContentTypeProvider = provider
}):
        }
    }
}
