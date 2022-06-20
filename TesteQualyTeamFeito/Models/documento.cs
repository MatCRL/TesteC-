using MySql.Data.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Web.Mvc;

namespace TesteQualyTeamFeito.Models
{

    [Table("documento")]
    public class documento
    {
   
        [Required(ErrorMessage = "Insira Um Código")]
        public int id { get; set; }
        [Required(ErrorMessage = "Titulo é obrigatório!")]
        public string titulo { get; set; }
        [Required(ErrorMessage = "Processo é obrigatório!")]
        public string processo { get; set; }
        [Required(ErrorMessage = "Categoria é obrigatório!")]
        public string categoria { get; set; }
        public string arquivo { get; set; }


    }

    //metodo para retornar a lista de documentos
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DocumentoDb : DbContext
    {
        //referencia para pegar um conjunto de documentos
        public DbSet<documento> Documentos { get; set; }

        public DocumentoDb() : base("DefaultConnection")
        {

        }
    }

}