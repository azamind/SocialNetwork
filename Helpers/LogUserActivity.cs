﻿using Microsoft.AspNetCore.Mvc.Filters;
using SocialNetworkProject.Extensions;
using SocialNetworkProject.Interfaces;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SocialNetworkProject.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;

            var userId = resultContext.HttpContext.User.GetUserId();
            var repository = resultContext.HttpContext.RequestServices.GetService<IUserRepository>();
            var user = await repository.GetUserByIdAsync(userId);
            user.LastActive = DateTime.Now;
            await repository.SaveAllAsync();
        }
    }
}
