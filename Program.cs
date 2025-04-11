using fluentNhibernateautoplay.entidades;
using fluentNhibernateautoplay.infra;
using NHibernate;

internal class Program
{
    private static void Main(string[] args)
    {
        ISession session = HibernateUtil.getSession();
        ITransaction transaction = session.BeginTransaction();

        Pedido pedido = session.Get<Pedido>(5);

        IQueryable<Pedido> query = session.Query<Pedido>();

        query = query.Where(pedido => pedido.Cliente.Nome == "Ciclano");
        
        IList<Pedido> pedidos = query.ToList();

        Console.WriteLine(pedidos[0].Cliente.Nome);

        transaction.Commit();
    }
}