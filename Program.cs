IHostBuilder builder = Host.CreateDefaultBuilder();

builder.ConfigureWebHostDefaults(async webBuilder => {
    webBuilder.UseStartup<MyStartUp>();
});

IHost host = builder.Build();
host.Run();

