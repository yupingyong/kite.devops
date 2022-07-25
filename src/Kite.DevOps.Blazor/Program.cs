using Kite.DevOps.Blazor;
using Kite.DevOps.Blazor.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host
     .ConfigureLogging((context, logBuilder) =>
     {
         Log.Logger = new LoggerConfiguration()
          .Enrich.FromLogContext()
          .WriteTo.Console()// ��־���������̨
          .MinimumLevel.Information()
          .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
          .CreateLogger();
         logBuilder.ClearProviders();
         logBuilder.AddSerilog(dispose: true);
     })
     .UseAutofac();

builder.Services.ReplaceConfiguration(builder.Configuration);//�������ô���

builder.Services.AddApplication<BlazorModule>();
builder.Services.AddHttpClient();
builder.Services.AddSingleton<AuthorizationServerStorage>();

var app = builder.Build();
await app.InitializeApplicationAsync();
await app.RunAsync();
