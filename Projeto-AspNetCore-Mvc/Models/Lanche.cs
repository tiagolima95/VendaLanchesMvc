using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_AspNetCore_Mvc.Models

{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [StringLength(100, MinimumLength = 10, ErrorMessage = "O {0} deverá ter no mínimo {1} e no máximo {2} caracteres")] 
        [Required(ErrorMessage = "Informe o nome da categoria")] 
        [Display(Name = "Nome do lanche")] 
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name ="Preço")]
        [Column(TypeName = "decimal(10,2)")] 
        [Range(1,999.99, ErrorMessage ="O preço dev estar entre 1 e 999,99")] 
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deverá ser informada!")]
        [Display(Name = "Descrição")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "A descrição deve ter no mínimo {1} e no máximo {2}")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deverá ser informada!")]
        [Display(Name = "Descrição detalhada do lanche")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "A descrição deve ter no mínimo {1} e no máximo {2}")]
        public string DescricaoDetalhada { get; set; }       
        

        [Display(Name = "Caminho da imagem normal")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O caminho deve ter no mínimo {1} e no máximo {2}")]
        public string ImageUrl { get; set; }

        [Display(Name = "Caminho da imagem miniatura")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O caminho deve ter no mínimo {1} e no máximo {2}")]
        public string ImageThumbnailUrl { get; set; }
        
        
        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
