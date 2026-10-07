using System.Threading.Tasks;

public partial class Program
{
    public static async Task RunAppAsync(string[] args) // renomeado
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Produto}/{action=Index}/{id?}");

        await app.RunAsync();
    }

    public static async Task Main(string[] args)
    {
        await Program.RunAppAsync(args);
    }
}