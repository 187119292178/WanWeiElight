﻿using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Elight.Utility.Operator;
using Elight.Logic.Sys;

namespace Elight.WebUI.Filters
{
    /// <summary>
    /// 表示一个特性，该特性用于标识用户是否有访问权限。
    /// </summary>
    public class AuthorizeCheckedAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 是否忽略权限检查。
        /// </summary>
        public bool Ignore { get; set; }

        public AuthorizeCheckedAttribute(bool ignore = false)
        {
            this.Ignore = ignore;
        }


        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            SysPermissionLogic logic = new SysPermissionLogic();
            if (Ignore)
            {
                return;
            }
            try
            {
                if (OperatorProvider.Instance.Current == null)
                {
                    string html = "<!DOCTYPE html><html><head><meta charset=\"utf-8\"><title></title></head><body><script>parent.window.location.href=\"/account/login\";</script></body></html>";
                    actionContext.Result = new ContentResult() { Content = html, ContentType = "text/html" };
                    return;
                }
                string userId = OperatorProvider.Instance.Current.UserId;
                var action = actionContext.HttpContext.Request.Path.Value;
                bool hasPermission = logic.ActionValidate(userId, action);
                if (!hasPermission)
                {
                    string html = "<!DOCTYPE html><html><head><meta charset=\"utf-8\"><title></title></head><body>对不起，您没有权限访问当前页面。</body></html>";
                    actionContext.Result = new ContentResult() { Content = html, ContentType = "text/html" };
                }
            }
            catch (Exception ex)
            {
                string html = "<!DOCTYPE html><html><head><meta charset=\"utf-8\"><title></title></head><body><script>parent.window.location.href=\"/account/login\";</script></body></html>";
                actionContext.Result = new ContentResult() { Content = html, ContentType = "text/html" };
                return;
            }
        }
    }
}