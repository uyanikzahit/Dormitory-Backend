using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RecordManager : IRecordService
    {
        public IResult Add(Record record)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Record record)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Record>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Record> GetById(int recordId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RecordDetailDto>> GetRecordByUserAndActivity(int userId, int activityId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RecordDetailDto>> GetRecordDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RecordDetailDto>> GetRecordDetailsId(int recordId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Record>> GetRecordsByActiviyId(int activityId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Record>> GetRecordsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RecordDetailDto>> SeeRecordsByActivityIdWithDetails(int activityId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RecordDetailDto>> SeeRecordsByUserIdWithDetails(int userId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Record record)
        {
            throw new NotImplementedException();
        }
    }
}
