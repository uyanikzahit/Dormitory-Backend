using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserImageDal : IEntityRepository<UserImage>
    {
        public List<RoomDetailDto> GetUserImageDetails();
    }
}
