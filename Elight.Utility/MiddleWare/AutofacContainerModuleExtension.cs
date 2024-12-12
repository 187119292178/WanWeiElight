#if !NETFRAMEWORK
using Autofac;
using Elight.Utility.Extension.SqlSugar;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using ServiceStack.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Elight.Utility.MiddleWare
{
    public static class AutofacContainerModuleExtension
    {
        private static List<Assembly> GetReferanceAssemblies(this AppDomain domain, string startWith = null)
        {
            var list = new List<AssemblyName>();
            var list3 = new List<string>();
            Assembly[] assemblyArray = domain.GetAssemblies();
            foreach (Assembly assembly in assemblyArray)
            {
                GetReferanceAssemblies(assembly, list, list3);
            }
            var list2 = new List<Assembly>();
            if (startWith != null)
            {
                foreach (AssemblyName assemblyName in list)
                {
                    if (assemblyName.Name.StartsWith(startWith))
                    {
                        list2.Add(Assembly.Load(assemblyName));
                    }
                }
            }
            else
            {
                foreach (AssemblyName assemblyName in list)
                {
                    list2.Add(Assembly.Load(assemblyName));
                }
            }
            return list2;
        }
        private static void GetReferanceAssemblies(Assembly assembly, List<AssemblyName> list, List<string> list3)
        {
            //自己加进去
            if (!list3.Contains(assembly.GetName().Name))
            {
                list3.Add(assembly.GetName().Name);
                list.Add(assembly.GetName());
            }
            AssemblyName[] assemblyNames = assembly.GetReferencedAssemblies();
            foreach (AssemblyName assemblyName in assemblyNames)
            {
                try
                {
                    var ass = Assembly.Load(assemblyName);
                    if (!list3.Contains(assemblyName.Name))
                    {
                        list3.Add(assemblyName.Name);
                        list.Add(assemblyName);
                        GetReferanceAssemblies(ass, list, list3);
                    }
                }
                catch (Exception ex) { }
            }
        }


        public static IServiceCollection AddModule(this IServiceCollection services, ContainerBuilder builder, IConfiguration configuration)
        {
            //var compilationLibrary = DependencyContext.Default.RuntimeLibraries.Where(x => !x.Serviceable && x.Type == "project").ToList();
            //List<Assembly> assemblyList = new List<Assembly>();

            //foreach (var _compilation in compilationLibrary)
            //{
            //    try
            //    {
            //        assemblyList.Add(AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName(_compilation.Name)));
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(_compilation.Name + ex.Message);
            //    }
            //}
            List<Assembly> assemblyList = AppDomain.CurrentDomain.GetReferanceAssemblies();
            foreach (var assembly in assemblyList)
            {
                foreach (var type in assembly.GetTypes())
                {
                    var serviceAttribute = type.GetCustomAttribute<AppServiceAttribute>();
                    if (serviceAttribute is not null)
                    {
                        //情况1：使用自定义[AppService(ServiceType = typeof(注册抽象或者接口))]，手动去注册，放type即可
                        var serviceType = serviceAttribute.ServiceType;
                        //情况2 自动去找接口，如果存在就是接口，如果不存在就是本身
                        if (serviceType == null)
                        {
                            //获取最靠近的接口
                            var firstInter = type.GetInterfaces().LastOrDefault();
                            if (firstInter is null)
                            {
                                serviceType = type;
                            }
                            else
                            {
                                serviceType = firstInter;
                            }
                        }

                        switch (serviceAttribute.ServiceLifetime)
                        {
                            case LifeTime.Singleton:
                                if (type.IsGenericType)
                                {
                                    builder.RegisterGeneric(type).As(serviceType).SingleInstance();
                                }
                                else
                                {
                                    builder.RegisterType(type).As(serviceType).SingleInstance();
                                }
                                break;
                            case LifeTime.Scoped:
                                if (type.IsGenericType)
                                {
                                    builder.RegisterGeneric(type).As(serviceType).InstancePerLifetimeScope();
                                }
                                else
                                {
                                    builder.RegisterType(type).As(serviceType).InstancePerLifetimeScope();
                                }
                                break;
                            case LifeTime.Transient:
                                if (type.IsGenericType)
                                {
                                    builder.RegisterGeneric(type).As(serviceType).InstancePerDependency();
                                }
                                else
                                {
                                    builder.RegisterType(type).As(serviceType).InstancePerDependency();
                                }
                                break;
                            default:
                                if (type.IsGenericType)
                                {
                                    builder.RegisterGeneric(type).As(serviceType).InstancePerDependency();
                                }
                                else
                                {
                                    builder.RegisterType(type).As(serviceType).InstancePerDependency();
                                }
                                break;
                        }
                    }
                }
            }
            return services;
        }
    }
}
#endif