using Elight.Logic;
using Elight.Logic.Sys;
using Elight.Utility.Logs;
using Elight.WebUI.Filters;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Elight.WebUI.Controllers
{
    [HiddenApi]
    public class ErrorController : BaseController
    {
        [HttpGet, Route("error")]
        public ActionResult Index()
        {
            IExceptionHandlerPathFeature iExceptionHandlerFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (iExceptionHandlerFeature != null)
            {
                Exception ex = iExceptionHandlerFeature.Error;
                Logger.ErrorInfo(ex.Message);//数据库就没必要存储StackTrace了
                LogHelper.Error(ex.StackTrace);//日志文件中存储详细错误信息，为了后期查找问题
            }
            ViewBag.StatusCode = "Error";
            return View();
        }

        [HttpGet, Route("error/notFound/{statusCode}")]
        public ActionResult Index(int statusCode)
        {
            var iStatusCodeReExecuteFeature = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            if (iStatusCodeReExecuteFeature != null)
            {
                string path = iStatusCodeReExecuteFeature.OriginalPath;
                Logger.ErrorInfo($"访问{path}过程发生异常，异常代码：{statusCode}");
            }
            else
            {
                Logger.ErrorInfo($"访问过程发生异常，异常代码：{statusCode}");
            }
            ViewBag.StatusCode = statusCode;
            return View();
        }
    }
}
