using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GestaoEscolar;

public class UnidadeCurricular
{
    public Guid Id {get;set;}

    [Required(ErrorMessage = "O Campo Nome é Obrigatório!")]
    [MaxLength(50,ErrorMessage ="O Campo Nome deve conter, no máximo, 50 caracters!")]
    [MinLength(3,ErrorMessage ="O Campo Nome deve conter, no mínimo, 3 caracters!")]
    public string? Nome {get;set;}

    [Required(ErrorMessage = "O Campo Carga Horária é Obrigatório!")]
    [Display(Name = "Carga Horária")]
    [Range(1,400, ErrorMessage = "A Carga Horária deve estar entre 1h até 400h")]
    public int CargaHoraria {get;set;}

    [Required(ErrorMessage = "O Campo Sigla é Obrigatório!")]
    [MaxLength(10,ErrorMessage ="O Campo Sigla deve conter, no máximo, 10 caracters!")]
    [MinLength(3,ErrorMessage ="O Campo Sigla deve conter, no mínimo, 3 caracters!")]
    public string? Sigla {get;set;}
}
