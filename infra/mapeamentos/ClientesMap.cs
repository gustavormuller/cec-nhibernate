using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using fluentNhibernateautoplay.entidades;
using MySqlX.XDevAPI;

namespace fluentNhibernateautoplay.infra.mapeamentos
{
    public class ClientesMap : ClassMap<Cliente>
    {
        public ClientesMap()
        {
            Schema("nHibernate");
            Table("cliente");
            Id(cliente => cliente.Id).Column("id");
            Map(cliente => cliente.Email).Column("email");
            Map(cliente => cliente.Nome).Column("nome");
            Map(cliente => cliente.Senha).Column("senha");
        }
        
    }
}