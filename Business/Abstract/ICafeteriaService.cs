using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICafeteriaService
    {
        IDataResult<List<Cafeteria>> GetAll();
        IResult Add(Cafeteria cafeteria);
        IResult Remove(Cafeteria cafeteria);
        IResult Update(Cafeteria cafeteria);
        IDataResult<Cafeteria> GetCafeteriaById(int cafeteriaId);
        IDataResult<Cafeteria> GetCafeteriaByDate(DateTime dateTime);


    }
}
