using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class MyMiddleware
    {
        private readonly RequestDelegate next;

        public MyMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context, IDatabase database)
        {
            context.Items.Add("ticks", database.Ticks);

            await next(context);
        }
    }
}
