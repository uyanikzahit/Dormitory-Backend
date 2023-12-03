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
    public interface IShcoolService
    {
        IDataResult<List<Shcool>> GetAll();
        IResult Add(Shcool shcool);
        IResult Remove(Shcool shcool);
        IResult Update(Shcool shcool);
        IDataResult<Shcool> GetShcoolById(int ShcoolId);
    }
}
