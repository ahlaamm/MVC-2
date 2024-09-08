namespace MVC_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(e => 
            { 
                e.MapControllerRoute(
                    name: "default", 
                    pattern: "{Controller=Home}/{Action=Index}/{id?}"
                    );
            });


            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
