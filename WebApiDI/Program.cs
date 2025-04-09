var builder = WebApplication.CreateBuilder(args);

// Register dependencies
builder.Services.AddTransient<IMessageSender, EmailSender>();
builder.Services.AddTransient<NotificationService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

