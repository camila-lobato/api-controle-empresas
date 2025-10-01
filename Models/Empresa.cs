using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using AtividadeAPI.Models.Dto;


namespace AtividadeAPI.Models
{
    [Table("empresa")]
    public class Empresa
    {
        [Column("id_emp")]
        public int Id { get; set; }

        [Column("razaoSocial_emp")]
        public required string RazaoSocial { get; set; }

        [Column("nomeFantasia_emp")]
        public required string NomeFantasia { get; set; }

        [Column("cnpj_emp")]
        public required string Cnpj { get; set; }

        [Column("inscricao_emp")]
        public required string Inscricao { get; set; }

        [Column("telefone_emp")]
        public required string Telefone { get; set; }

        [Column("email_emp")]
        public required string Email { get; set; }

        [Column("cidade_emp")]
        public required string Cidade { get; set; }

        [Column("estado_emp")]
        public required string UF {  get; set; }

        [Column("cep_emp")]
        public required string Cep { get; set; }

        [Column("dataCadastro_emp")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

    }
}
