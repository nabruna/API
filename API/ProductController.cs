using Microsoft.AspNetCore.Mvc;

namespace API;
[ApiController]
//define controller path
[Route("/product")]
public class ProductController : ControllerBase
{
    [Route("list")]
    [HttpGet]
    public string List(){
        return "Hello world";
    }
}
