using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        
        public string ActivityTitle { get; set; }

        public string ActivityDescription { get; set; }

        public DateTime Date { get; set; }


    }
}
