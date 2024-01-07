using Business.Abstract;
using Core.Utilities.Results;
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
        public IResult Add(Work work)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Work work)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Work>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Work> GetById(int workId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Work work)
        {
            throw new NotImplementedException();
        }
    }
}
