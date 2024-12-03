namespace OficinaAPI.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } // Chave estrangeira
        public Cliente Cliente { get; set; } // Navegação
        public DateTime DataServico { get; set; }
        public string Descricao { get; set; } // Descrição do serviço
        public decimal CustoTotal { get; set; } // Custo total do serviço
        public ICollection<ItemServico> Itens { get; set; } // Itens relacionados ao serviço
    }
}
