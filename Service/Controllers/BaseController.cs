using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Ascend.MUService.Service.Controllers
{
    
    public abstract class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        public IConfiguration Configuration { get; }
        public int? UserID { get; set; }
        public string JWTToken { get; set; }
        public string SessionKey { get; set; }

        protected BaseController(IConfiguration configuration, ILogger<BaseController> log)
        {
            Configuration = configuration;
            logger = log;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (this.User != null)
            {
                
            }
            base.OnActionExecuting(context);
        }
    }
}
