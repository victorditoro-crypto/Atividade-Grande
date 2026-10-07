public partial class Program
{
    // renomeado para não conflitar com outro Main existente
    public static void Run(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Aluno}/{action=Index}/{id?}");

        app.Run();
    }
}

#if !SYMBOL_OTHER_MAIN
public partial class Program
{
    public static void MainFromProgram(string[] args)
    {
        Program.Run(args);
    }
}
#endif