using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Annotations.Models
{
    [Table("Pessoa")]
    public class Person
    {
        [Key]
        [Column("PessoaId", TypeName = "int")] 
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonId { get; set; }
        
        [Column("Nome", TypeName = "ntext")]
        [Display(Name = "Seu Nome")]
        public string Name { get; set; }

        [Column("CPF", TypeName = "ntext")]
        [Display(Name = "Cadastro de pessoa física")]
        public string CPF { get; set; }

        [Column("Nascimento", TypeName = "date")]
        [Display(Name = "Sua data de nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Column("Idade", TypeName = "int")]
        [Display(Name = "Sua Idade")]
        public int Age { get; set; }
    }
}
