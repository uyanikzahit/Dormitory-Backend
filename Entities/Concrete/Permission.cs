using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public int UserId { get; set; }
        public int PermissionDay { get; set; }


    }
}
