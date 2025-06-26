using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacAlimentacao;

public class Usuario
{
    [Key] // Chave primária para o pedido de cozinha
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Gera automaticamente o valor da chave primária
    //criar as propriedades 
    public int Id { get; set; }//id,
    public string Nome { get; set; }//nome,
    public string Email { get; set; }//email,
    public string Senha { get; set; }//senha,
    public bool Ativo { get; set; }//tipo
}
