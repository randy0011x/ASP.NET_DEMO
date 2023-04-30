public class MyStartup{

    public void configure(IApplicationBuilder app)
    {
        app.Run(async context =>
        {
            await context.Response.WriteAsync("Hello,World");
        });

    }

}