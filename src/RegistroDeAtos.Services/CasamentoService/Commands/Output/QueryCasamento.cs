using System.ComponentModel.DataAnnotations;

namespace RegistroDeAtos.Services.CasamentoService.Commands.Output
{
    public class QueryCasamento
    {
        public Guid Id { get; set; }
        [Display(Name ="Data Registro")]
        public DateTime DataRegistro { get; set; }
        [Display(Name = "Nome Conjuge Um")]
        public string NomeConjugeUm { get; set; }
        [Display(Name = "Data de Nascimento Conjuge Um")]
        public DateTime DataNascimentoConjugeUm { get; set; }
        [Display(Name = "Cpf Conjuge Um")]
        public string CpfConjugeUm { get; set; }
        
        public string NomePaiConjugeUm { get; set; }
        public string NomeMaeConjugeUm { get; set; }

        public string NomeConjugeDois { get; set; }
        public DateTime DataNascimentoConjugeDois { get; set; }
        public string CpfConjugeDois { get; set; }

        public string NomePaiConjugeDois { get; set; }
        public string NomeMaeConjugeDois { get; set; }

    }
}