using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ReallySimpleMicroservice
{
    //[Route("api/example/")]
    public class ExampleController : ApiController
    {
        
        [Route("api/LogIn")]
        //[HttpGet]
        public string GetLogIn()
        {
            return "LogIn";
        }

        //[Route("SigIn/?user={user}&password={password}")]
        //[HttpPost]
        [Route("Sigin")]
        //[HttpGet]
        public bool GetSingIn([FromUri]string user, [FromUri]string password)
        {
            return (user == "user" && password == "secret");
        }
    }
}
