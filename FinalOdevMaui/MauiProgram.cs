﻿using Microsoft.Extensions.Logging;
using FinalOdevHazirlikMaui.Models; // FirebaseServices sınıfının bulunduğu namespace

namespace FinalOdevHazirlikMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Epilogue-Medium.ttf", "Epilogue");
                    fonts.AddFont("fontello.ttf", "Icons");
                    fonts.AddFont("fontello2.ttf", "Icons2");
                });

            // FirebaseServices'i singleton olarak ekleyin
            builder.Services.AddSingleton<FirebaseServices>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
