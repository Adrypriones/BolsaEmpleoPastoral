using Microsoft.AspNetCore.Http;
using PastoralEmpleo.Shared.Utils;
using System.Collections.Generic;
using System.Linq;

namespace PastoralEmpleo.Services
{
    public class AuthorizationService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthorizationService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool IsAuthorized(string permissionCode)
        {
            var permissions = _httpContextAccessor.HttpContext.Session.GetObject<Dictionary<int, string>>("Permissions");
            
            if(permissions.Any())
            {
                return permissions.ContainsValue(permissionCode);
            }

            return false;
        }
    }
}
