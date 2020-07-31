using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class TestController : ApiController
    {
        public string Get() => 
#if DEBUG
        "debug";
#else
        "d";
#endif      
    }
}
