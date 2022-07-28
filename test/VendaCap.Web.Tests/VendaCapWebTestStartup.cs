using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace VendaCap;

public class VendaCapWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<VendaCapWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
