using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Data.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.Id = new Guid().ToString();
        }
        public String Id { get; set; }
    }
}
