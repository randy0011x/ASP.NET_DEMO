var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers(options=> options.EnableEndpointRouting = false);
//services.AddMvc(options => options.EnableEndpointRouting = false);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
// app.UseMvc(
//     routes=>{
//         routes.MapRoute(
//             name:"Default",
//             template:"{controller=Home}/{action=Index}/{id?}"
//         );
//     }
// );
//conventional routing
// app.UseMvc(
//     routes=>{
//         routes.MapRoute(
//             name:"blog",
//             template:"myblog/{id:int}",
//             defaults: new {Controller="Blog", Action="Story"}
//         );
//     }
// );
app.Run();
