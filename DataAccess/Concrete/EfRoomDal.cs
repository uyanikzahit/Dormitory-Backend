using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfRoomDal : EfEntityRepositoryBase<Room, DormitoryContext>, IRoomDal
    {
        public List<RoomDetailDto> GetRoomDetails()
        {
            using (DormitoryContext context = new DormitoryContext())
            {
                var roomDetails = from r in context.Rooms
                                  join u in context.Users
                                  on r.StudentId equals u.Id
                                  select new RoomDetailDto
                                  {
                                      Email = u.Email,
                                      FirstName = u.FirstName,
                                      LastName = u.LastName,

                                  };
                return roomDetails.ToList();
            }
        }

    }
}
