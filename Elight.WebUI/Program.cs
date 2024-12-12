using System;
using System.IO;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Elight.WebUI;
using Elight.Service.WebService;
using Elight.Utility.Extension;
using Elight.Utility.MiddleWare;
using Elight.WebUI.Filters;
using Lazy.Captcha.Core.Generator;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.DependencyModel;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SkiaSharp;
using SoapCore;
using UEditorNetCore;
using SqlSugar.Extensions;
using System.ComponentModel;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddCommandLine(args);
builder.WebHost.UseUrls("http://*:8080");
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Services.Init(builder.Configuration);

builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    //builder.Services.AddModule(containerBuilder, builder.Configuration);
});
builder.Logging.ClearProviders()
               .AddFilter("System", LogLevel.Warning)
               .AddFilter("Microsoft", LogLevel.Warning)
               .AddLog4Net(MyEnvironment.RootPath("/Configs/log4net.config"));
builder.Services.Configure<FormOptions>(options =>
{
    options.MultipartBodyLengthLimit = long.MaxValue;
    options.ValueLengthLimit = int.MaxValue;

});
builder.Services.Configure<KestrelServerOptions>(options =>
{
    //options.AllowSynchronousIO = true;
    options.Limits.MaxRequestBodySize = 50 * 1024 * 1024; // 50M
    options.Limits.MaxConcurrentConnections = 100;
    options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(60);
});
builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = 50 * 1024 * 1024; // 50M
    options.MaxRequestBodyBufferSize = 50 * 1024 * 1024;
    options.AllowSynchronousIO = true;
});


//注册使用验证码
builder.Services.AddDistributedMemoryCache().AddCaptcha(option =>
{
    option.CaptchaType = CaptchaType.NUMBER; // 验证码类型
    option.CodeLength = 4; // 验证码长度, 要放在CaptchaType设置后
    option.ExpirySeconds = 30;//验证码过期时间30秒 
    option.IgnoreCase = true; // 比较时是否忽略大小写
    option.ImageOption.Animation = true; // 是否启用动画 
    option.ImageOption.Width = 80; // 验证码宽度
    option.ImageOption.Height = 30; // 验证码高度
    option.ImageOption.BackgroundColor = SKColors.White; // 验证码背景色 
    option.ImageOption.BubbleCount = 2; // 气泡数量
    option.ImageOption.BubbleMinRadius = 5; // 气泡最小半径
    option.ImageOption.BubbleMaxRadius = 15; // 气泡最大半径
    option.ImageOption.BubbleThickness = 1; // 气泡边沿厚度 
    option.ImageOption.InterferenceLineCount = 2; // 干扰线数量 
    option.ImageOption.FontSize = 28; // 字体大小
                                      //option.ImageOption.FontFamily = DefaultFontFamilys.Instance.Actionj; // 字体，中文使用kaiti，其他字符可根据喜好设置（可能部分转字符会出现绘制不出的情况）。
});
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(AppSetting.SessionTimeout);
});
//使用缓存
builder.Services.AddMemoryCache();
builder.Services.AddMvc();
builder.Services.AddSqlsugarServer(AppSetting.DBType, AppSetting.DbConnectionString);
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;//防止接口把属性改成小写
    options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
    options.JsonSerializerOptions.Converters.Add(new Elight.Utility.Core.DateTimeConverter());
    options.JsonSerializerOptions.Converters.Add(new Elight.Utility.Core.DateTimeNullableConverter());
});
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddUEditorService("Configs/ueditor.json");
//services.AddRazorPages();
//注册Swagger生成器，定义一个和多个Swagger 文档
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        // {ApiName} 定义成全局变量，方便修改
        Version = "v1",
        Title = "My API"
    });
    //在接口类、方法标记属性 [HiddenApi]，可以阻止【Swagger文档】生成 
    c.DocumentFilter<HiddenApiFilter>();
    c.OrderActionsBy(o => o.RelativePath);
    //var basePath = System.AppDomain.CurrentDomain.BaseDirectory;//获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
    //var xmlPath = Path.Combine(basePath, "Elight.WebUI.Core.xml");
    //if (File.Exists(xmlPath))//避免没有该文件时报错
    //    c.IncludeXmlComments(xmlPath);
});

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.TryAddSingleton<WebServiceContract>();

var app = builder.Build();
MyHttpContext.ServiceProvider = app.Services;
//app.UseDeveloperExceptionPage();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
    app.UseStatusCodePagesWithReExecute("/error/notFound/{0}");
    app.UseHsts();
}
//启用Session
app.UseSession();

//配置WebService
app.UseSoapEndpoint<WebServiceContract>("/WebService.asmx", new SoapEncoderOptions());

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
});


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();