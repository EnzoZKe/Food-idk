using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAAAA_FUNCIONA_MDS.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key] 
        public int CategoriaId { get; set; }
        public string NomeCategoria { get; set; }   
    }
}