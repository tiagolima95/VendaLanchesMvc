﻿namespace Projeto_AspNetCore_Mvc.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string DescricaoDetalhada { get; set; }
        public string DescricaoCurta { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
