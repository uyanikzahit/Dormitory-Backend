using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities.Concrete
{
    public class Announcement : IEntity
    {
        public Announcement()
        {
            AnnouncementDate = DateTime.Now;
        }

        public int Id { get; set; }

        public string AnnouncementTitle { get; set; }

        public string AnnouncementDescription { get; set; }

        public DateTime AnnouncementDate { get; set; }
    }
}
