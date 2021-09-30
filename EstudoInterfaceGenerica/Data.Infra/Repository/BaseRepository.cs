using Data.Domain.Models;
using Data.Domain.Repository;
using Data.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infra.Repository
{
    public abstract class BaseRepository<M> : IBaseRepository<M> where M : Base
    {
        public async Task<M> ObterClienteId(int id)
        {
            using (var dbSet = new BancoContext())
            {
                return await dbSet.Set<M>().FirstOrDefaultAsync(c => c.Id == id);
            }
        }

        public async Task<M> ObterClienteCodigo(string codigo)
        {
            using (var dbSet = new BancoContext())
            {
                return await dbSet.Set<M>().FirstOrDefaultAsync(c => c.Codigo == codigo);
            }
        }

        public async Task<M> ObterClienteGuid(Guid guid)
        {
            using (var dbSet = new BancoContext())
            {
                return await dbSet.Set<M>().FirstOrDefaultAsync(c => c.Guid == guid);
            }
        }
    }
}
