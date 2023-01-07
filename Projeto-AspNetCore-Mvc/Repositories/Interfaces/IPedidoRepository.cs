using Projeto_AspNetCore_Mvc.Models;

namespace Projeto_AspNetCore_Mvc.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> Pedidos { get;  }

        public void CriarPedido(Pedido pedido);
    }
}
