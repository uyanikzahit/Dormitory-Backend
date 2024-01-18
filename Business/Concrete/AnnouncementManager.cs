using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        [ValidationAspect(typeof(AnnouncementValidator))]
        [CacheRemoveAspect("AnnouncementService.Get")]
        public IResult Add(Announcement announcement)
        {
            _announcementDal.Add(announcement);
            return new SuccessResult(Messages.AnnouncementAdded);
        }


        [CacheAspect]
        [PerformanceAspect(7)]
        public IDataResult<List<Announcement>> GetAll()
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll(), Messages.AnnouncementsListed);
        }


        [CacheAspect]
        [PerformanceAspect(7)]
        public IDataResult<Announcement> GetAnnouncementById(int AnnouncementId)
        {
            return new SuccessDataResult<Announcement>(_announcementDal.Get(b => b.Id == AnnouncementId), (Messages.AnnouncementListed));
        }


        [CacheRemoveAspect("AnnouncementService.Get")]
        public IResult Delete(Announcement announcement)
        {
            _announcementDal.Delete(announcement);
            return new SuccessResult(Messages.AnnouncementDeleted);
        }

        [ValidationAspect(typeof(AnnouncementValidator))]
        [CacheRemoveAspect("AnnouncementService.Get")]
        public IResult Update(Announcement announcement)
        {
            _announcementDal.Update(announcement);
            return new SuccessResult(Messages.AnnouncementUpdated);
        }
    }
}
