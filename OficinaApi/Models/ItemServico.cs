namespace OficinaAPI.Models
{
    public class ItemServico
    {
        public int Id { get; set; }
        public int ServicoId { get; set; } // Chave estrangeira
        public Servico Servico { get; set; } // Navegação
        public string Descricao { get; set; } // Descrição da peça ou tarefa
        public int Quantidade { get; set; }
        public decimal Preco { get; set; } // Preço unitário
    }
}
