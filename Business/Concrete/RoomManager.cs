using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
        IUserDal _userDal;

        public RoomManager(IRoomDal roomDal, IUserDal userDal)
        {
            _roomDal = roomDal;
            _userDal = userDal;
        }

        [ValidationAspect(typeof(RoomValidator))]
        [CacheRemoveAspect("RoomService.Get")]
        public IResult Add(Room room)
        {
            IResult result = BusinessRules.Run(CheckIfRoomNumberExists(room.RoomNumber));
            if (result != null)
            {
                return result;
            }
            var userExists = _userDal.Get(u => u.Id == room.UserId);
            if (userExists == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }

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


        [CacheRemoveAspect("RoomService.Get")]
        public IResult Remove(Room room)
        {
            _roomDal.Delete(room);
            return new SuccessResult(Messages.RoomDeleted);
        }

        [ValidationAspect(typeof(RoomValidator))]
        [CacheRemoveAspect("RoomService.Get")]
        public IResult Update(Room room)
        {
            var userExists = _userDal.Get(u => u.Id == room.UserId);
            if (userExists == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            _roomDal.Update(room);
            return new SuccessResult(Messages.RoomUpdated);
        }


        private IResult CheckIfRoomNumberExists(int roomNumber)
        {
            //var result = _roomDal.GetAll(p => p.RoomNumber == roomNumber).Any();
            //if (result)
            //{
            //    return new ErrorResult(Messages.RoomNumberAlreadyExists);
            //}
            return new SuccessResult();
        }
    }
}
