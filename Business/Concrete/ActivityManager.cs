using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        IActivityService _activityService;

        public ActivityManager(IActivityService activityService)
        {
            _activityService = activityService;
        }

        public IResult Add(Activity activity)
        {
            _activityService.Add(activity);
            return new SuccessResult();
        }

        public IDataResult<List<Activity>> GetAll()
        {
            return new SuccessDataResult<List<Activity>>(_activityService.GetAll());
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
