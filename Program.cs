using fluentNhibernateautoplay.entidades;
using fluentNhibernateautoplay.infra;
using NHibernate;

internal class Program
{
    private static void Main(string[] args)
    {
        ISession session = HibernateUtil.getSession();
        ITransaction transaction = session.BeginTransaction();

        Cliente cliente = session.Get<Cliente>(1);

        Pedido pedido = new Pedido(cliente);

        session.Save(pedido);

        transaction.Commit();
    }
}