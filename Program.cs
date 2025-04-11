using fluentNhibernateautoplay.entidades;
using fluentNhibernateautoplay.infra;
using NHibernate;

internal class Program
{
    private static void Main(string[] args)
    {
        ISession session = HibernateUtil.getSession();
        ITransaction transaction = session.BeginTransaction();

        Produto produto1 = new Produto("Caderno", 10.50f);
        Produto produto2 = new Produto("Caneta", 1.50f);
        Produto produto3 = new Produto("Borracha", 0.50f);

        IList<Produto> produtos = [produto1, produto2, produto3];

        session.Save(produto1);
        session.Save(produto2);
        session.Save(produto3);

        Cliente cliente = session.Get<Cliente>(1);

        Pedido pedido = new Pedido(cliente, produtos);
        session.Save(pedido);


        transaction.Commit();
    }
}