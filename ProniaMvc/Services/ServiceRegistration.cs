using ProniaMvc.ExtentionsServices.Implements;
using ProniaMvc.ExtentionsServices.Interfaces;
using ProniaMvc.Services.Implements;
using ProniaMvc.Services.Interfaces;

namespace ProniaMvc.Services;

public static class ServiceRegistration
{
    public static void AddService(this IServiceCollection services)
    {
        services.AddScoped<ISliderService, SliderService>();
        services.AddScoped<IFileService, FileService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<LayoutService>();
    }
}
