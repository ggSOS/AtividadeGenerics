namespace AtividadeGenerics
{
       internal class Program
    {
        static void Main(string[] args)
        {
            Estoque<string> produto = new Estoque<string>();
            Console.WriteLine("\nLista produto:");
            produto.ListarTodos();
            produto.Adicionar("Banana");
            produto.Adicionar("Maca");
            produto.Adicionar("Uva");
            produto.BuscarPorID(2);
            produto.RemoverPorID(2);
            produto.ListarTodos();

            Estoque<string> usuario = new Estoque<string>();
            Console.WriteLine("\nLista usuario:");
            usuario.ListarTodos();
            usuario.Adicionar("Gerso");
            usuario.Adicionar("Leticio");
            usuario.Adicionar("Cleiton");
            usuario.BuscarPorID(1);
            usuario.RemoverPorID(1);
            usuario.ListarTodos();

            Estoque<string> pedido = new Estoque<string>();
            Console.WriteLine("\nLista pedido:");
            pedido.ListarTodos();
            pedido.Adicionar("Tenis");
            pedido.Adicionar("Camiseta");
            pedido.Adicionar("Calca");
            pedido.BuscarPorID(0);
            pedido.RemoverPorID(0);
            pedido.ListarTodos();
        }
    }
}