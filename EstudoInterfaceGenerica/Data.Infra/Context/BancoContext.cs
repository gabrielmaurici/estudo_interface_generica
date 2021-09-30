using Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infra.Context
{
    public class BancoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<HistoricoIntegracao> HistoricosIntegracoes { get; set; }
        public BancoContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gabriel\Documents\Dev\Projetos\estudo_interface_generica\EstudoInterfaceGenerica\Data.Infra\Db\BancoContext.mdf;Integrated Security=True")
        {

        }
    }
}
