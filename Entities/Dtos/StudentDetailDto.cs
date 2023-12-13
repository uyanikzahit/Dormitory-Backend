using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class StudentDetailDto : IEntity
    {
        public int StudentId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set;}
        public int RoomId { get; set; }
        public int RoomNumber { get; set; }
        public string BlokName { get; set; }
        public int FloorNumber { get; set; }
        public int ShcoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolSection { get; set; }
    }
}
