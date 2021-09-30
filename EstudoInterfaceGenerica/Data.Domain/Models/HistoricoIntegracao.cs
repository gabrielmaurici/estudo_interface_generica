using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain.Models
{
    public class HistoricoIntegracao : Base
    {
        public decimal Score { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
