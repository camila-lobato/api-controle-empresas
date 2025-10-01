using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace AtividadeAPI.Models.Dto
{
    public class EmpresaDto
    {
        [Required (ErrorMessage = "Campo obrigatório!")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength (14, MinimumLength = 14, ErrorMessage = "Quantidade de caracteres inválida!")]
        public string Cnpj {  get; set; }

        public string Inscricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Quantidade de caracteres inválida!")]
        public string Telefone {  get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [EmailAddress(ErrorMessage = "Formato inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression("^(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)$",
            ErrorMessage = "UF inválida!")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Formato inválido!")]
        public string Cep { get; set; }

    }
}
