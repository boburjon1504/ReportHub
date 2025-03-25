namespace ReportHub.Api.Configurations;

public static partial class HostConfiguration
{
    public static Task ConfigureAsync(this WebApplicationBuilder builder)
    {
        builder
            .AddConfigurationSettings()
            .AddInfrastructures()
            .AddPersistence()
            .AddAuth()
            .AddExposers()
            .AddDevTools();

        return Task.CompletedTask;
    }

    public static Task ConfigureAsync(this WebApplication app)
    {
        app
            .UseDevTools()
            .UseAuth()
            .UseExposers();

        return Task.CompletedTask;
    }
}
