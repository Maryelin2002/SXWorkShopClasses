using FluentValidation.AspNetCore;
using GenericApi.Bl.Validations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApi.Config
{
    public static class FluentValidationConfig
    {
        public static IMvcBuilder AddValidation(this IMvcBuilder builder)
        {
            builder.AddFluentValidation(x =>
            {
                x.AutomaticValidationEnabled = false;
                x.RegisterValidatorsFromAssemblyContaining<DocumentValidator>();
            });
            return builder;
        }
    }
}
