using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Student :IEntity
    {
        public int StudentId { get; set; }
        public int RoomId { get; set; }
        public int ShcoolId { get; set; }
        public int PermissionId { get; set; }
    }
}
