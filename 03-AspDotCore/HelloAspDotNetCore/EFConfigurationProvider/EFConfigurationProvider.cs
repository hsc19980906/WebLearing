using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloAspDotNetCore.EFConfigurationProvider
{
    /// <summary>
    /// 创建自定义配置提供程序：
    /// 当数据库为空时，配置提供程序将其初始化
    /// </summary>
    public class EFConfigurationProvider:ConfigurationProvider
    {
        Action<DbContextOptionsBuilder> OptionAction { get; }
        public EFConfigurationProvider(Action<DbContextOptionsBuilder> optionAction) 
        { 
            OptionAction = optionAction;
        }

        //从数据库加载配置数据
        public override void Load()
        {
            var builder = new DbContextOptionsBuilder<EFConfigurationContext>();
            OptionAction(builder);
            using (var dbContext=new EFConfigurationContext(builder.Options))
            {
                dbContext.Database.EnsureCreated();

                Data = !dbContext.Values.Any() ? CreateAndSaveDefaultValues(dbContext) :
                    dbContext.Values.ToDictionary(c => c.Id, c => c.Value);
            }
        }

        private static IDictionary<string, string> CreateAndSaveDefaultValues(EFConfigurationContext dbContext)
        { 
            var configValues=new Dictionary<string, string>()
            {
                {"quote1","I aim to misbehave" },
                {"quote2","I swallowed a bug" },
                {"quote3","You can't stop the signal,Mal." },
            };

            dbContext.Values.AddRange(configValues.Select(kvp=>new Models.EFConfigurationValue() { Id = kvp.Key, Value = kvp.Value}).ToArray());

            dbContext.SaveChanges();

            return configValues;
        }
    }
}
