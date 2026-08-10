using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace MyHighEndApp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
        {
                var builder = MauiApp.CreateBuilder();
                        builder.UseMauiApp<App>();
                                builder.Services.AddMauiBlazorWebView();
                                        return builder.Build();
                                            }
                                            }