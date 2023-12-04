using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class School : IEntity
    {
        public int SchoolId { get; set; }

        public string SchoolName { get; set; }

        public string SchoolSection { get; set; }
    }
}
