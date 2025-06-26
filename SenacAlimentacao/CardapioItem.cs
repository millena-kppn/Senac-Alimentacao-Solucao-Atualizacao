using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao;

public class CardapioItem
{
    [Key] // Chave primária para o pedido de cozinha
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Gera automaticamente o valor da chave primária
    public int Id { get; set; } // Identificador único do item
    public string Titulo { get; set; } // Titulo do item do cardápio
    public string Descricao { get; set; } // Descrição do item do cardápio
    public decimal Preco { get; set; } // Preço do item do cardápio
    public bool PossuiPreparo { get; set; } // Categoria do item se ele possui preparo ou não
}
