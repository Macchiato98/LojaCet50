using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCet50.Models.Dados.Entidades
{
    public class Clientes
    {
        public int Id { get; set; }


        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [Display(Name = "Apelido")]
        public string Apelido { get; set; }


        [Display(Name = "Morada")]
        public string Morada { get; set; }


        [Display(Name = "Telefone")]
        public int NumeroTelefone { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime DatadeNascimento { get; set; }
    }
}
