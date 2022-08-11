using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
    [HttpGet("validate/{cpf}")]
    public object validate ([FromServices] CpfService cpfService, 
    string cpf)
    {
        throw new NotImplementedException();
    }
    [HttpGet("generate")]
    public object Generate ()
    {
        throw new NotImplementedException();
    }
}
