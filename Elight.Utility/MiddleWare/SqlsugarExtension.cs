﻿#if !NETFRAMEWORK
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using System;
using System.Collections.Generic;

namespace Elight.Utility.MiddleWare
{
    public static class SqlsugarExtension
    {
        public static void AddSqlsugarServer(this IServiceCollection services, string type, string connectionString)
        {
            DbType dbType;
            var slavaConFig = new List<SlaveConnectionConfig>();
            switch (type.ToUpper())
            {
                case "MYSQL": dbType = DbType.MySql; break;
                case "SQLITE": dbType = DbType.Sqlite; break;
                case "SQLSERVER": dbType = DbType.SqlServer; break;
                case "MSSQL": dbType = DbType.SqlServer; break;
                case "ORACLE": dbType = DbType.Oracle; break;
                default: throw new Exception("配置写的TM是个什么东西？");
            }
            SqlSugarScope sqlSugar = new SqlSugarScope(new ConnectionConfig()
            {
                //准备添加分表分库
                DbType = dbType,
                ConnectionString = connectionString,
                IsAutoCloseConnection = true,
                MoreSettings = new ConnMoreSettings()
                {
                    DisableNvarchar = true
                },
                SlaveConnectionConfigs = slavaConFig,
                //设置codefirst非空值判断
                ConfigureExternalServices = new ConfigureExternalServices
                {
                    EntityService = (c, p) =>
                    {
                        //// int?  decimal?这种 isnullable=true
                        if (c.PropertyType.IsGenericType && c.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        {
                            p.IsNullable = true;
                        }
                        //高版C#写法 支持string?和string  
                        //if (new NullabilityInfoContext().Create(c).WriteState is NullabilityState.Nullable)
                        //{
                        //    p.IsNullable = true;
                        //}
                    }
                }
            },
         db =>
         {
             db.Aop.DataExecuting = (oldValue, entityInfo) =>
             {
                 //var httpcontext = ServiceLocator.Instance.GetService<IHttpContextAccessor>().HttpContext;
                 switch (entityInfo.OperationType)
                 {
                     case DataFilterType.InsertByObject:
                         if (entityInfo.PropertyName == "CreateUser")
                         {
                             //entityInfo.SetValue(new Guid(httpcontext.Request.Headers["Id"].ToString()));
                         }
                         else if (entityInfo.PropertyName == "CreateTime")
                         {
                             //entityInfo.SetValue(new Guid(httpcontext.Request.Headers["TenantId"].ToString()));
                         }
                         else if (entityInfo.PropertyName == "ModifyUser")
                         {
                             //entityInfo.SetValue(new Guid(httpcontext.Request.Headers["Id"].ToString()));
                         }
                         else if (entityInfo.PropertyName == "ModifyTime")
                         {
                             //entityInfo.SetValue(new Guid(httpcontext.Request.Headers["TenantId"].ToString()));
                         }
                         break;
                     case DataFilterType.UpdateByObject:
                         if (entityInfo.PropertyName == "ModifyUser")
                         {
                             //entityInfo.SetValue(new Guid(httpcontext.Request.Headers["Id"].ToString()));
                         }
                         else if (entityInfo.PropertyName == "ModifyTime")
                         {
                             //entityInfo.SetValue(DateTime.Now);
                         }
                         break;
                 }

             };
             db.Aop.OnLogExecuting = (s, p) =>
             {
                 //if (GobalModel.SqlLogEnable)
                 //{
                 //    var _logger = ServiceLocator.Instance?.GetRequiredService<ILogger<SqlSugarClient>>();
                 //StringBuilder sb = new StringBuilder();
                 //sb.Append("执行SQL:" + s.ToString());
                 //foreach (var i in p)
                 //{
                 //    sb.Append($"\r\n参数:{i.ParameterName},参数值:{i.Value}");
                 //}
                 //Console.WriteLine(sb.ToString());
                 //    _logger?.LogInformation(sb.ToString());
                 //}
             };
         });
            services.AddSingleton<ISqlSugarClient>(sqlSugar);//这边是SqlSugarScope用AddSingleton
        }
    }
}
#endif