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
        public int EatId { get; set; }

        public DateTime Date { get; set; }

        public string MorningMenu { get; set; }

        public string EveningMenu { get; set; }

        public string CommentSuggestion { get; set; }
        public string Complaint { get; set; }
    }
}
