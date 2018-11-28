using System.Collections.Generic;
using MyAppWeb.Entidades;

namespace MyAppWeb
{
    public interface IProdutoRepository
    {
        List<Produto> ListarProdutos();
        Produto ObterProdutoPorId(int id);
        void Salvar(Produto produto);
    }
}