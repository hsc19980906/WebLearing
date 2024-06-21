using HelloAspDotNetCore.EFConfigurationProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace HelloAspDotNetCore.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static IConfigurationBuilder AddEFConfiguration(this IConfigurationBuilder builder,
            Action<DbContextOptionsBuilder> optionsAction) 
        { 
            return builder.Add(new EFConfigurationSource(optionsAction));
        }
    }
}
