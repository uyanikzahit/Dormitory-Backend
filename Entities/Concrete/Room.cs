using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Room : IEntity
    {
        public int RoomId {  get; set; }

        public int StudentId { get; set; }

        public int RoomNumber { get; set; }

        public string BlockName { get; set; }

        public int FloorNumber { get; set; }



        




    }
}
