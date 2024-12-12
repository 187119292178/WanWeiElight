#if !NETFRAMEWORK && !WINDOWS
using Elight.Utility.Extension;

namespace Elight.Utility.MiddleWare
{
    public class AutofacContainerModule
    {
        public static TService GetService<TService>() where TService : class
        {
            return MyHttpContext.ServiceProvider.GetService(typeof(TService)) as TService;
        }
    }
}
#endif
