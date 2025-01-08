using Microsoft.Extensions.DependencyInjection;
using SerilogDemo.Application.Contacts;

namespace SerilogDemo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IContactsService, ContactsService>();

        return services;
    }
}