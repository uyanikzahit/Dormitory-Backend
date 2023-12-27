using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRecordService
    {
        IResult Add(Record record);
        IResult Update(Record record);
        IResult Delete(Record record);
        IDataResult<List<Record>> GetAll();
        IDataResult<Record> GetById(int recordId);
        IDataResult<List<Record>> GetRecordsByUserId(int userId);
        IDataResult<List<Record>> GetRecordsByActivityId(int activityId);
        IDataResult<List<RecordDetailDto>> GetRecordDetails();
        IDataResult<List<RecordDetailDto>> GetRecordDetailsId(int recordId);
        IDataResult<List<RecordDetailDto>> SeeRecordsByUserIdWithDetails(int userId);
        IDataResult<List<RecordDetailDto>> SeeRecordsByActivityIdWithDetails(int activityId);
        IDataResult<List<RecordDetailDto>> GetRecordByUserAndActivity(int userId, int activityId);
    }
}
