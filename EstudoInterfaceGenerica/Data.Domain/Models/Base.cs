using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain.Models
{
    public class Base
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Codigo { get; set; }
    }
}
