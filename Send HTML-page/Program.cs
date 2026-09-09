var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles(); // Автоматично шукає index.html при запиті до кореня (має йти перед UseStaticFiles)
app.UseStaticFiles();  // Обробляє запити до файлів у папці wwwroot

app.Run();