using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Concrete
{
    public class Cafeteria : IEntity
    {
        public Cafeteria()
        {
            Date = DateTime.Now;
        }
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string MorningMenu { get; set; }

        public string EveningMenu { get; set; }

    }
}
