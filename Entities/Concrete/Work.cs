using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities.Concrete
{
    public class Work : IEntity
    {
        public int Id { get; set; }
        public string EmployerFirstName { get; set; }
        public string EmployerLastName { get; set; }
        public string WorkDescription { get; set; }
        public Date Date { get; set; }

    }
}
