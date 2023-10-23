using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AAAAA_FUNCIONA_MDS.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public bool EmEstoque { get; set; }
        public decimal Preco { get; set; }
        
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}