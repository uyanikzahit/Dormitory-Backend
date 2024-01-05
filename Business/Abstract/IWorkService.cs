using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkService 
    {
        IResult Add(Work work);
        IResult Update(Work work);
        IResult Delete(Work work);
        IDataResult<List<Work>> GetAll();
        IDataResult<Work> GetById(int workId);
    }
}
