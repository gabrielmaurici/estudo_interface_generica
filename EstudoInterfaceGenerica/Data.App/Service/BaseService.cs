using Data.Domain.Models;
using Data.Domain.Repository;
using Data.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.App.Service
{
    public abstract class BaseService<M> : IBaseService<M> where M : Base
    {
        private readonly IBaseRepository<M> _baseRepository;
        public BaseService() { }
        public BaseService(IBaseRepository<M> baseRepository)
        {
            this._baseRepository = baseRepository;
        }

        public Task<M> ObterClienteCodigo(string codigo)
        {
            return _baseRepository.ObterClienteCodigo(codigo);
        }

        public Task<M> ObterClienteGuid(Guid guid)
        {
            return _baseRepository.ObterClienteGuid(guid);
        }

        public Task<M> ObterClienteId(int id)
        {
            return _baseRepository.ObterClienteId(id);
        }
    }
}
