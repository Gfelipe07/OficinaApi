namespace OficinaAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public ICollection<Servico> Servicos { get; set; } // Relacionamento com Serviços
    }
}
