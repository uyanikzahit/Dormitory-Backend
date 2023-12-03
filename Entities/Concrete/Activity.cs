using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Activity : IEntity
    {
        public Activity()
        {
            Date = DateTime.Now;
        }

        public int ActivityId { get; set; }
        
        public string ActivityName { get; set; }

        public DateTime Date { get; set; }
    }
}
