using Microsoft.AspNetCore.Mvc;
using GraphQL.Types;

namespace GraphQLApi.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
