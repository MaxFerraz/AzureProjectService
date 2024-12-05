using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public string Bairro { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public List<UserRole> UserRoles { get; set; }
    public string FotoPerfil { get; set; } = string.Empty;
    public string CPF_CNPJ { get; set; } = string.Empty;
    public string RG_IE { get; set; } = string.Empty;
    public DateTime DataNascimento { get; set; }

    //public ICollection<UserHistoricoProfissional> UserHistoricosProfissionais { get; }

}

public class UserRole
{
    public long Id { get; set; }
    public string Description { get; set; }
}

