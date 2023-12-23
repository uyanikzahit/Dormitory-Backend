using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities.Concrete
{
    public class Cafeteria : IEntity
    {
        public int EatId { get; set; }

        public Date Date { get; set; }

        public string MorningMenu { get; set; }

        public string EveningMenu { get; set; }

        public string CommentSuggestion { get; set; }

        public int UserId {  get; set; }
    }
}
