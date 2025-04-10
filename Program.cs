using fluentNhibernateautoplay.entidades;
using fluentNhibernateautoplay.infra;
using NHibernate;

internal class Program
{
    private static void Main(string[] args)
    {
        ISession session = HibernateUtil.getSession();

        Cliente cliente = new Cliente("Beltrano", "Beltrano@gmail.com", "senhasegura");

        session.Save(cliente);

        Console.WriteLine((int)session.Save(cliente));
    }
}