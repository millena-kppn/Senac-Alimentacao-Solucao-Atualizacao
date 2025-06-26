using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao;

public class Mesa
{
    [Key] // Chave primária para o pedido de cozinha
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Gera automaticamente o valor da chave primária
    public int Id  { get; set; }
    public int NumeroMesa { get; set; } // Número da mesa
    //0 - Livre, 1 - Ocupada, 2 - Reservada
    public int SituacaoMesa { get; set; } // Número de pessoas na mesa
}
