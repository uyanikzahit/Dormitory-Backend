using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IActivityService
    {
        IDataResult<List<Activity>> GetAll();
        IResult Add(Activity activity);
        IResult Remove(Activity activity);
        IResult Update(Activity activity);
        IDataResult<Activity> GetActivityById(int activityId);
    }
}
