using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Shcool : IEntity
    {
        public int SchoolId { get; set; }

        public string ShcoolName { get; set; }

        public string ShcoolSection { get; set; }
    }
}
