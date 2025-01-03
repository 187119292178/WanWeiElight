﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Elight.Utility.Threads
{
    /// <summary>
    /// Action工具类
    /// </summary>
    public static class ActionUtil
    {
        #region TryDoAction
        /// <summary>
        /// 带异常处理的Action
        /// </summary>
        public static void TryDoAction(Action action, Action<Exception> errorAction = null)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                if (errorAction != null) errorAction(ex);
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region TryDoFunc
        /// <summary>
        /// 带异常处理的Func
        /// </summary>
        public static TResult TryDoFunc<TResult>(Func<TResult> func, Action<Exception> errorAction = null)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                if (errorAction != null) errorAction(ex);
                Console.WriteLine(ex.Message);
                return default(TResult);
            }
        }
        #endregion

    }
}
