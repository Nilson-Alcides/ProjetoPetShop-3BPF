using System.ComponentModel.DataAnnotations;

namespace ProjetoPetShop.Models
{
    public class Raca
    {
        /*
         create table Raca(
         id_raca int primary key auto_increment,
         nome varchar(40) not null
         );  
         */
        [Display(Name = "Código")]
        public int id { get; set; }

        [Display(Name = "Raça")]
        [Required(ErrorMessage = "A raça é obrigatório")]
        public string nome { get; set; }
    }
}
