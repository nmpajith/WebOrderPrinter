﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataAccessLayer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Root
{
    public class CompositionRoot
    {
        public CompositionRoot() { }

        public static void RegisterDependencies(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<WebOrderPrinterDbContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString(nameof(WebOrderPrinterDbContext))));
        }
    }
}
