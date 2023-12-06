using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        [ValidationAspect(typeof(RoomValidator))]
        public IResult Add(Room room)
        {
            _roomDal.Add(room);
            return new SuccessResult(Messages.RoomAdded);
        }

        [CacheAspect]
        [PerformanceAspect(7)]
        public IDataResult<List<Room>> GetAll()
        {
            return new SuccessDataResult<List<Room>>(_roomDal.GetAll(),Messages.RoomsListed);
        }

        [CacheAspect]
        [PerformanceAspect(7)]
        public IDataResult<Room> GetRoomById(int roomId)
        {
            return new SuccessDataResult<Room>(_roomDal.Get(r=>r.RoomId == roomId));
        }

        public IResult Remove(Room room)
        {
            _roomDal.Delete(room);
            return new SuccessResult(Messages.RoomDeleted);
        }

        [ValidationAspect(typeof(RoomValidator))]
        public IResult Update(Room room)
        {
            _roomDal.Update(room);
            return new SuccessResult(Messages.RoomUpdated);
        }
    }
}
