namespace RegistroDeAtos.Services.Comum
{
    public class ConjugeCommand
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public PessoaFisicaCommand Pai { get; set; } = new PessoaFisicaCommand();
        public PessoaFisicaCommand Mae { get; set; } = new PessoaFisicaCommand();
        public DocumentoCommand DocPai { get; set; } = new DocumentoCommand();
        public DocumentoCommand DocMae { get; set; } = new DocumentoCommand();
        public DocumentoCommand Documento { get; set; } = new DocumentoCommand();
    }
}