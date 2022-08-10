using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test/")]
public class TestController:ControllerBase
{
    [HttpGet]    
    public string TesteGet()
    {
        return "My app is Working!";
    }
}