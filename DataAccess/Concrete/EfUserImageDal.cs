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
    public class EfUserImageDal : EfEntityRepositoryBase<UserImage, DormitoryContext>, IUserImageDal
    {
        public List<RoomDetailDto> GetUserImageDetails()
        {
            using (DormitoryContext context = new DormitoryContext())
            {
                var roomDetails = from i in context.UserImages
                                  join u in context.Users
                                  on i.UserId equals u.Id
                                  select new RoomDetailDto
                                  {
                                      UserId= u.Id,
                                      Email = u.Email,
                                      FirstName = u.FirstName,
                                      LastName = u.LastName,

                                  };
                return roomDetails.ToList();
            }
        }
    }
}
