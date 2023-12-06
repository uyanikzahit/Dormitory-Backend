using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IDataResult<List<Room>> GetAll();
        IResult Add(Room room);
        IResult Remove(Room room);
        IResult Update(Room room);
        IDataResult<Room> GetRoomById(int roomId);
    }
}
