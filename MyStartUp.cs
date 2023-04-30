


public class MyStartUp {
    public void ConfigureServices(IServiceCollection services) {

    }
    public void Configure(IApplicationBuilder app, IHostEnvironment env) {
        app.UseRouting();

        app.UseEndpoints(endpoints => {
            endpoints.MapGet("/about", async context => {
                await context.Response.WriteAsync("Introduction");
            });
        });
    }
}