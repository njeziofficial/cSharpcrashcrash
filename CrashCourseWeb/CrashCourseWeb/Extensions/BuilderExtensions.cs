﻿using CrashCourseWeb.Middlewares;

namespace CrashCourseWeb.Extensions;

public static class BuilderExtensions
{
    public static void ExtendBuilder(this IApplicationBuilder app)
    {
        app.UseDeveloperExceptionPage();
        app.UseMiddleware<ErrorHandlerMiddleware>();
    }
}
