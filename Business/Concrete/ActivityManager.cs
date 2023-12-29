using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        //[ValidationAspect(typeof(ActivityValidator))]
        public IResult Add(Activity activity)
        {
            _activityDal.Add(activity);
            return new SuccessResult();
        }

        [CacheAspect]
        [PerformanceAspect(7)]
        public IDataResult<List<Activity>> GetAll()
        {
            return new SuccessDataResult<List<Activity>>(_activityDal.GetAll(), Messages.ActivitiesListed);
        }

        [CacheAspect]
        [PerformanceAspect(7)]
        public IDataResult<Activity> GetActivityById(int activityId)
        {
            return new SuccessDataResult<Activity>(_activityDal.Get(c => c.ActivityId == activityId), Messages.ActivityListed);
        }

        public IResult Remove(Activity activity)
        {
            _activityDal.Delete(activity);
            return new SuccessResult(Messages.ActivityDeleted);

        }
        [ValidationAspect(typeof(ActivityValidator))]
        public IResult Update(Activity activity)
        {
            _activityDal.Update(activity);
            return new SuccessResult(Messages.ActivityUpdated);
        }
    }
}
