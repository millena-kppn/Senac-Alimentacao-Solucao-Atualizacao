using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao;

public class ComandaItem
{
    [Key] // Chave primária para o pedido de cozinha
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Gera automaticamente o valor da chave primária
    public int Id { get; set; } //id do item da comanda
    public int ComandaId { get; set; } //id da comanda associada
    public int CardapioItemId { get; set; } //id do item do cardápio associado à comanda
}
