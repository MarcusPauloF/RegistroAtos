namespace RegistroDeAtos.Services.CasamentoService.Commands.Output
{
    public class QueryCasamento
    {
        public Guid Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public string NomeConjugeUm { get; set; }
        public string DataNascimentoConjugeUm { get; set; }
        public string CpfConjugeUm { get; set; }
        
        public string NomePaiConjugeUm { get; set; }
        public string NomeMaeConjugeUm { get; set; }

        public string NomeConjugeDois { get; set; }
        public string DataNascimentoConjugeDois { get; set; }
        public string CpfConjugeDois { get; set; }

        public string NomePaiConjugeDois { get; set; }
        public string NomeMaeConjugeDois { get; set; }

    }
}