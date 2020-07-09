using Microsoft.AspNetCore.Http;
using System.Security.Claims;


namespace MyFinances.Database.UserInfo
{
    public class UserSingleton
    {
        private static UserSingleton _instance;

        private static object _lock = new object();

        private IHttpContextAccessor _context;

        private UserSingleton()
        {
        }

        public static UserSingleton GetUserSingleton()
        {
            lock (_lock)
            {
                return _instance ?? (_instance = new UserSingleton());
            }
        }

        public IHttpContextAccessor SetContext
        {
            set => _context ??= value;
        }


        public bool IsUserLogged => _context.HttpContext.User.Identity.IsAuthenticated;

        public string GetUserId => _context.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
