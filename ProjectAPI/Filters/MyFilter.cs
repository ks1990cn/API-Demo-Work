using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Filters
{
    public class MyFilter : Attribute,IAsyncActionFilter
    {
        private string _lol;
        public MyFilter(string lol)
        {
            this._lol = lol;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine(this._lol);
            await next();
            Console.WriteLine(this._lol);
        }
    }
}
