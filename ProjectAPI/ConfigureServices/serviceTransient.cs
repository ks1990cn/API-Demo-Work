using Microsoft.Extensions.DependencyInjection;
using ProjectAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.ConfigureServices
{
    public static class serviceTransient
    {
       public static void setTransient(IServiceCollection services)
        {
            services.AddTransient<IMockRepository, MockRepository>();
        }

    }
}
