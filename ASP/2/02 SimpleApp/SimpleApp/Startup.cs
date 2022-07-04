using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SimpleApp
{
	public class Startup {
		public void ConfigureServices(IServiceCollection services) {
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			}

			app.UseStaticFiles();

			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
			/*app.UseEndpoints(endpoints => {
				endpoints.MapControllerRoute(
				name: "WithCategory",
				pattern: "{controller=Products}/{action=List}/{category}");

				endpoints.MapControllerRoute(
				name: "NonCategory",
				pattern: "{controller=Products}/{action=List}");

			});*/
		}
    }
}
