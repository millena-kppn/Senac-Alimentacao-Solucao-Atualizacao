using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao;

public class PedidoCozinha
{
    [Key] // Chave primária para o pedido de cozinha
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Gera automaticamente o valor da chave primária
    public int Id { get; set; } //id do pedido de cozinha
    public int ComandaId { get; set; } //id da comanda associada ao pedido
    public int SituacaoId { get; set; } //id da situação do pedido
}
