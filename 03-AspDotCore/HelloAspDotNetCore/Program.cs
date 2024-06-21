using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAspDotNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder创建和配置生成器对象
            //对生成器对象调用Build和Run方法
            CreateHostBuilder(args).Build().Run();
            
        }

        /// <summary>
        /// 创建主机用来封装应用资源的对象---用于生命周期管理，控制应用程序的启动和正常关闭
        /// （1）依赖关系注入（DI）
        /// （2）Logging日志
        /// （3）配置
        /// （4）IHostedService实现自动注册服务：IHostApplicationLifetime、
        /// IHostLifetime、IHostEnvironment/IWebHostEnvironment
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            ///CreateDefaultBuilder完成以下事情
            ///一、加载主机配置
            ///（1）前缀为“DOTNET_”的环境变量
            ///（2）命令行参数
            ///二、加载应用配置
            ///（1）appsettings.json
            ///（2）appsettings.{Environment}.json
            ///（3）密钥管理器（当应用在Development环境中运行时）
            ///（4）环境变量
            ///（5）命令行参数
            ///三、添加日志记录
            ///（1）控制台（2）调试（3）EventSource
            ///（4）EventLog（仅当在Windows上运行时）
            ///四、当应用在Development环境中运行时，启用范围验证和依赖关系验证
            Host.CreateDefaultBuilder(args)
                ///ConfigureWebHostDefaults完成以下事情
                ///（1）用前缀为“ASPNETCORE_”的环境变量加载主机配置
                ///（2）使用应用的托管配置程序，将Kestrel服务器设置为Web服务器并对其进行配置
                ///（3）添加主机筛选中间件
                ///（4）如果ASPNETCORE_FORWARDEDHEADERS_ENABLED=true，则添加转发的标头中间件
                ///（5）支持IIS集成
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
