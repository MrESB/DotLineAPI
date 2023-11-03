using DotLineAPI.Model;

internal class Program
{
    //Abolfazl EsmaeelBeigi
    //Tamrin 6
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<IDotLine, Linecalculator>();
        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Dot}/{action=Index}");

        app.Run();
    }
}
