using Microsoft.AspNetCore.Mvc;
using SocialNetworkProject.Helpers;

namespace SocialNetworkProject.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
