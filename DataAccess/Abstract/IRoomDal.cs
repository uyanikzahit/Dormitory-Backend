﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRoomDal : IEntityRepository<Room>
    {
        public List<RoomDetailDto> GetRoomDetails();
    }
}
