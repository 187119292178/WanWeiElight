using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elight.WebUI.Filters;
using Microsoft.AspNetCore.Mvc;
using UEditorNetCore;

namespace Elight.WebUI.Controllers
{
    [HiddenApi]
    public class UEditorController : Controller
    {
        private UEditorService ue;
        public UEditorController(UEditorService ue)
        {
            this.ue = ue;
        }

        [HttpGet, HttpPost, Route("api/UEditor")] //配置路由
        public void Do()
        {
            ue.DoAction(HttpContext);
        }
    }
}