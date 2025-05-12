using WebApiPasquali.Models;
using WebApiPasquali.Services.Interfaces;

namespace WebApiPasquali.Services.Implementations;

public class PessoaService : IPessoaService
{
    public List<Pessoa> ObterPessoas()
    {
        var pessoas = new List<Pessoa>();

        for (int i = 1; i <= 30; i++)
        {
            pessoas.Add(new Pessoa
            {
                Cpf = $"443.231.423-{i:00}",
                Nome = $"Pessoa {i}",
                Genero = i % 2 == 0 ? "Masculino" : "Feminino",
                Endereco = $"Rua {i}",
                Idade = 20 + i,
                Municipio = $"Município {i % 5 + 1}",
                Estado = "SP"
            });
        }

        return pessoas;
    }
}
