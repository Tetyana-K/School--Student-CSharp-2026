using Serilog;

Log.Logger = new LoggerConfiguration)
            .WriteTo.Console()
            .WriteTo.File("logs/log.txt")
            .CreateLogger();

Log.Information("Application started");

try
{
    int a = 10;
    int b = 0;
    int c = a / b;
}
catch (Exception ex)
{
    Log.Error(ex, "Error occurred");
}

Log.CloseAndFlush();