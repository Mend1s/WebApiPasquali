using Microsoft.AspNetCore.Mvc;
using WebApiPasquali.Services.Interfaces;

namespace WebApiPasquali.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoasController : ControllerBase
{
    private readonly IPessoaService _pessoaService;

    public PessoasController(IPessoaService pessoaService)
    {
        _pessoaService = pessoaService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var pessoas = _pessoaService.ObterPessoas();
        return Ok(pessoas);
    }
}
