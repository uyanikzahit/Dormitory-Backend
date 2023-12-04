using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISchoolService
    {
        IDataResult<List<School>> GetAll();
        IResult Add(School school);
        IResult Remove(School school);
        IResult Update(School school);
        IDataResult<School> GetShcoolById(int schoolId);
    }
}
