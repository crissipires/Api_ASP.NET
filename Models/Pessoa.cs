using System.ComponentModel.DataAnnotations;

namespace apidotnet5.Models
{
    public class Pessoa
    {
       [Key]
       public int Id { get; set; } 
       public string Nome { get; set; } 
       public string Cidade { get; set; } 
       public int AnoNascimento { get; set; } 
    }
}