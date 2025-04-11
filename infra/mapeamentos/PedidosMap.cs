using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using fluentNhibernateautoplay.entidades;

namespace fluentNhibernateautoplay.infra.mapeamentos
{
    public class PedidosMap : ClassMap<Pedido>
    {
        public PedidosMap()
        {
            Schema("nhibernate");
            Table("Pedido");
            Id(pedido => pedido.Id).Column("id");
            Map(pedido => pedido.DataPedido).Column("dataPedido");
            References(pedido => pedido.Cliente).Column("idCliente");
            HasManyToMany(pedido => pedido.Produtos)
                .Table("itemProduto")
                .ParentKeyColumn("idPedido")
                .ChildKeyColumn("idProduto")
                .Cascade.All();
        }
    }
}