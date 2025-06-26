using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao;

public class PedidoCozinhaItem
{
    [Key]// Chave primária para o item do pedido de cozinha
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Gera automaticamente o valor da chave primária
    public int Id { get; set; } //id do item do pedido de cozinha
    public int PedidoCozinhaId { get; set; } //id do pedido de cozinha associado
    public int ComandaItemId { get; set; } //id do item da comanda associado ao pedido de cozinha
}
