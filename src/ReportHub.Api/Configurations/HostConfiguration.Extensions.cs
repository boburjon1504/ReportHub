namespace ReportHub.Api.Configurations;

public static partial class HostConfiguration
{
    static WebApplicationBuilder AddConfigurationSettings(this WebApplicationBuilder builder)
    {
        // Adding setting you have used in appsettings.json

        return builder;
    }
    static WebApplicationBuilder AddInfrastructures(this WebApplicationBuilder builder)
    {
        // Add services in here

        return builder;
    }

    static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
    {
        // Add database configurations and repositories

        return builder;
    }
    static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        builder
            .Services
            .AddRouting(o =>
            {
                o.LowercaseUrls = true;
                o.LowercaseQueryStrings = true;
            })
            .AddControllers();

        return builder;
    }

    static WebApplicationBuilder AddAuth(this WebApplicationBuilder builder)
    {
        // Add authentications and authorizations here

        return builder;
    }

    static WebApplicationBuilder AddDevTools(this WebApplicationBuilder builder)
    {
        builder
            .Services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();

        return builder;
    }

    static WebApplication UseDevTools(this WebApplication app)
    {
        app
            .UseSwagger()
            .UseSwaggerUI();

        return app;
    }
    static WebApplication UseAuth(this WebApplication app)
    {
        // Use auth in here

        return app;
    }
    static WebApplication UseExposers(this WebApplication app)
    {
        app
            .MapControllers();

        return app;
    }


}
