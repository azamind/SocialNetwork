﻿using System.Security.Claims;

namespace SocialNetworkProject.Extensions
{
    public static class ClaimsPrincipleExtension
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
