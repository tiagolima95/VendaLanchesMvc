﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_AspNetCore_Mvc.Models
{
    [Table("Categorias")] 
    public class Categoria
    {
        [Key] 
        public int CategoriaId { get; set; }
       
        [StringLength(100, ErrorMessage = "O tamanho máximo é de {1} caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")] 
        [Display(Name = "Nome da categoria")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de {1} caracteres")] 
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
