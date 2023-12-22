using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RecordManager : IRecordService
    {
        IRecordDal _recordDal;

        public RecordManager(IRecordDal recordDal)
        {
            _recordDal = recordDal;
        }

        [ValidationAspect(typeof(RecordValidator))]

        public IResult Add(Record record)
        {
            _recordDal.Add(record);
            return new SuccessResult(Messages.RecordAdded);
        }

        public IResult Delete(Record record)
        {
            _recordDal.Delete(record);
            return new SuccessResult(Messages.RecordDeleted);
        }

        [PerformanceAspect(7)]
        public IDataResult<List<Record>> GetAll()
        {
            if (DateTime.Now.Hour == 23.00)
            {
                return new SuccessDataResult<List<Record>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Record>>(_recordDal.GetAll(),Messages.RecordsListed);
            }
        }

        [CacheAspect]
        [PerformanceAspect(7)]
        public IDataResult<Record> GetById(int recordId)
        {
            return new SuccessDataResult<Record>(_recordDal.Get(r=>r.Id==recordId));
        }

        public IDataResult<List<RecordDetailDto>> GetRecordByUserAndActivity(int userId, int activityId)
        {
            return new SuccessDataResult<List<RecordDetailDto>>(_recordDal.GetRecordByUserAndActivity(userId, activityId));
        }

        public IDataResult<List<RecordDetailDto>> GetRecordDetails()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<RecordDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<RecordDetailDto>>(_recordDal.GetRecordDetails(), Messages.RecordDetailsListed);
        }

        public IDataResult<List<RecordDetailDto>> GetRecordDetailsId(int recordId)
        {
            List<RecordDetailDto> recordDetails = _recordDal.GetRecordDetails(c => c.RecordId == recordId);
            if (recordDetails == null)
            {
                return new ErrorDataResult<List<RecordDetailDto>>("");
            }
            else
            {
                return new SuccessDataResult<List<RecordDetailDto>>(recordDetails, "");
            }
        }

        public IDataResult<List<Record>> GetRecordsByActiviyId(int activityId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(a => a.ActivityId == activityId));
        }

        public IDataResult<List<Record>> GetRecordsByUserId(int userId)
        {
            return new SuccessDataResult<List<Record>>(_recordDal.GetAll(u=>u.UserId == userId));
        }

        public IDataResult<List<RecordDetailDto>> SeeRecordsByActivityIdWithDetails(int activityId)
        {
            List<RecordDetailDto> recordDetails = _recordDal.GetRecordDetails(c => c.ActivityId == activityId);
            if (recordDetails == null)
            {
                return new ErrorDataResult<List<RecordDetailDto>>("");
            }
            else
            {
                return new SuccessDataResult<List<RecordDetailDto>>(recordDetails, "");
            }
        }

        public IDataResult<List<RecordDetailDto>> SeeRecordsByUserIdWithDetails(int userId)
        {
            List<RecordDetailDto> recordDetails = _recordDal.GetRecordDetails(c => c.UserId == userId);
            if (recordDetails == null)
            {
                return new ErrorDataResult<List<RecordDetailDto>>("");
            }
            return new SuccessDataResult<List<RecordDetailDto>>(recordDetails, "");
            
        }

        [ValidationAspect(typeof(RecordValidator))]

        public IResult Update(Record record)
        {
            _recordDal.Update(record);
            return new SuccessResult(Messages.RecordUpdated);
        }
    }
}
