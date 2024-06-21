using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace HelloAspDotNetCore.EFConfigurationProvider
{
    public class EFConfigurationSource : IConfigurationSource
    {
        private readonly Action<DbContextOptionsBuilder> _optionAction;

        public EFConfigurationSource(Action<DbContextOptionsBuilder> optionAction)
        {
            _optionAction = optionAction;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new EFConfigurationProvider(_optionAction);
        }
    }
}
