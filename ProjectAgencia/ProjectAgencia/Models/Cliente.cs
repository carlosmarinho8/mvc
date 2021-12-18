using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectAgencia.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; } 
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}