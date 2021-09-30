using Data.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain.Service
{
    public interface IBaseService<M> where M: Base
    {
        Task<M> ObterClienteId(int id);
        Task<M> ObterClienteCodigo(string codigo);
        Task<M> ObterClienteGuid(Guid guid);
    }
}
