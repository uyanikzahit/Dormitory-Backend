using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Record :IEntity
    {
        public Record()
        {
            Date = DateTime.Now;
        }

        public int Id { get; set; }
        public string RecordName { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int ActivityId { get; set; }




    }
}
