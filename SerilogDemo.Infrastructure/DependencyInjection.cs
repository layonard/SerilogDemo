using Microsoft.Extensions.DependencyInjection;
using SerilogDemo.Application.Abstractions;
using SerilogDemo.Infrastructure.Data;

namespace SerilogDemo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IContactsRepository, ContactsRepository>();

        return services;
    }
}