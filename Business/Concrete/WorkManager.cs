using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WorkManager : IWorkService
    {
        IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public IResult Add(Work work)
        {
            _workDal.Add(work);
            return new SuccessResult(Messages.WorkAdded);
        }

        public IResult Delete(Work work)
        {
            _workDal.Delete(work);
            return new SuccessResult(Messages.WorkDeleted);
        }

        public IDataResult<List<Work>> GetAll()
        {
            return new SuccessDataResult<List<Work>>(_workDal.GetAll(), Messages.WorksListed);

        }

        public IDataResult<Work> GetById(int workId)
        {
            return new SuccessDataResult<Work>(_workDal.Get(b => b.Id == workId), Messages.WorkListed);

        }

        public IResult Update(Work work)
        {
            _workDal.Update(work);
            return new SuccessResult(Messages.WorkUpdated);
        }
    }
}
