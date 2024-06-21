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
            //CreateHostBuilder��������������������
            //���������������Build��Run����
            CreateHostBuilder(args).Build().Run();
            
        }

        /// <summary>
        /// ��������������װӦ����Դ�Ķ���---�����������ڹ�������Ӧ�ó���������������ر�
        /// ��1��������ϵע�루DI��
        /// ��2��Logging��־
        /// ��3������
        /// ��4��IHostedServiceʵ���Զ�ע�����IHostApplicationLifetime��
        /// IHostLifetime��IHostEnvironment/IWebHostEnvironment
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            ///CreateDefaultBuilder�����������
            ///һ��������������
            ///��1��ǰ׺Ϊ��DOTNET_���Ļ�������
            ///��2�������в���
            ///��������Ӧ������
            ///��1��appsettings.json
            ///��2��appsettings.{Environment}.json
            ///��3����Կ����������Ӧ����Development����������ʱ��
            ///��4����������
            ///��5�������в���
            ///���������־��¼
            ///��1������̨��2�����ԣ�3��EventSource
            ///��4��EventLog��������Windows������ʱ��
            ///�ġ���Ӧ����Development����������ʱ�����÷�Χ��֤��������ϵ��֤
            Host.CreateDefaultBuilder(args)
                ///ConfigureWebHostDefaults�����������
                ///��1����ǰ׺Ϊ��ASPNETCORE_���Ļ�������������������
                ///��2��ʹ��Ӧ�õ��й����ó��򣬽�Kestrel����������ΪWeb�������������������
                ///��3���������ɸѡ�м��
                ///��4�����ASPNETCORE_FORWARDEDHEADERS_ENABLED=true�������ת���ı�ͷ�м��
                ///��5��֧��IIS����
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
