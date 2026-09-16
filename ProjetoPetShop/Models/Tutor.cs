using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoPetShop.Models
{
    public class Tutor
    {
        /*
         create table Tutor(
        id_tutor int primary key auto_increment,
        nome varchar(65) not null,
        telefone varchar(15) not null,
        email varchar(30) not null   
        );
         */
        [Display(Name = "Código")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo nome do tutor é obrigatorio")]
        public string nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O campo do telefone é obrigatorio")]
        public string telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo do email é obrigatorio")]
        public string email { get; set; }
    }
}
