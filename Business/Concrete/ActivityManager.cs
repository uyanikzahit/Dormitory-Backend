using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ActivityManager : IActivityService
    {

        IActivityDal _activityDal;

        public ActivityManager(IActivityDal activityDal)
        {
            _activityDal = activityDal;
        }

        public IResult Add(Activity activity)
        {
            _activityDal.Add(activity);
            return new SuccessResult();
        }

        public IDataResult<List<Activity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Activity> GetShcoolById(int ActivityId)
        {
            throw new NotImplementedException();
        }

        public IResult Remove(Activity activity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}
