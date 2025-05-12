using WebApiPasquali.Models;

namespace WebApiPasquali.Services.Interfaces;

public interface IPessoaService
{
    List<Pessoa> ObterPessoas();
}
