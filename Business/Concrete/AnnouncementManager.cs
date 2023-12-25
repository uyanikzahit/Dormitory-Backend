using Business.Abstract;
using Business.Constants;
using Business.FluentValidation;
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
        public IResult Add(Announcement announcement)
        {
            _announcementDal.Add(announcement);
            return new SuccessResult(Messages.AnnouncementAdded);
        }

        public IDataResult<List<Announcement>> GetAll()
        {
            return new SuccessDataResult<List<Announcement>>(_announcementDal.GetAll(), Messages.AnnouncementsListed);
        }

        public IDataResult<Announcement> GetAnnouncementById(int AnnouncementId)
        {
            return new SuccessDataResult<Announcement>(_announcementDal.Get(b => b.Id == AnnouncementId), (Messages.AnnouncementListed));
        }

        public IResult Delete(Announcement announcement)
        {
            _announcementDal.Delete(announcement);
            return new SuccessResult(Messages.AnnouncementDeleted);
        }

        [ValidationAspect(typeof(AnnouncementValidator))]
        public IResult Update(Announcement announcement)
        {
            _announcementDal.Update(announcement);
            return new SuccessResult(Messages.AnnouncementUpdated);
        }
    }
}
