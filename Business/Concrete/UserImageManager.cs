using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserImageManager : IUserImageService
    {
        IUserImageDal _userImageDal;
        IFileHelper _fileHelper;
        IUserDal _userDal;

        public UserImageManager(IUserImageDal userImageDal, IFileHelper fileHelper, IUserDal userDal)
        {
            _userImageDal = userImageDal;
            _fileHelper = fileHelper;
            _userDal = userDal;
        }


        [CacheRemoveAspect("UserImageService.Get")]
        public IResult Add(IFormFile file, UserImage userImage)
        {
            IResult result = BusinessRules.Run(CheckIfUserImageLimit(userImage.Id));
            if (result != null)
            {
                return result;
            }
            //Güncellenecek.
            var userExists = _userDal.Get(u => u.Id == userImage.UserId);
            if (userExists == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            userImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagePath);
            userImage.Date = DateTime.Now;
            _userImageDal.Add(userImage);
            return new SuccessResult(Messages.UserImageAdded);
        }


        [CacheRemoveAspect("UserImageService.Get")]
        public IResult Delete(UserImage userImage)
        {
            _fileHelper.Delete(PathConstants.ImagePath + userImage.ImagePath);
            _userImageDal.Delete(userImage);
            return new SuccessResult(Messages.UserImageDeleted);
        }


        [CacheAspect]
        public IDataResult<List<UserImage>> GetAll()
        {
            return new SuccessDataResult<List<UserImage>>(_userImageDal.GetAll());

        }

        [CacheAspect]
        public IDataResult<UserImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<UserImage>(_userImageDal.Get(c => c.Id == imageId));

        }

        [CacheAspect]
        public IDataResult<List<UserImage>> GetByUserId(int userId)
        {
            var result = BusinessRules.Run(CheckUserImageExists(userId));
            if (result != null)
            {
                return new ErrorDataResult<List<UserImage>>(GetDefaultImage(userId).Data);
            }
            return new SuccessDataResult<List<UserImage>>(_userImageDal.GetAll(u => u.Id == userId));
        }

        [CacheRemoveAspect("UserImageService.Get")]
        public IResult Update(IFormFile file, UserImage userImage)
        {
            var userExists = _userDal.Get(u => u.Id == userImage.UserId);
            if (userExists == null)
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            userImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagePath + userImage.ImagePath, PathConstants.ImagePath);
            userImage.Date = DateTime.Now;
            _userImageDal.Update(userImage);
            return new SuccessResult(Messages.UserImageUpdated);
        }



        //İŞ KURALLARI

        //Kullanıcı 1 den fazla resim yüklediğini kontrol eder.
         private IResult CheckIfUserImageLimit(int userId)
        {
            var result = _userImageDal.GetAll(c => c.Id == userId).Count;
            if (result >= 1)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        //Kullanıcının resminin olmadığını kontrol ediyoruz.
        private IResult CheckUserImageExists(int userId)
        {
            var result = _userImageDal.GetAll(u => u.Id == userId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        //Varsayılan resmi aldıran iş kuralı.
        private IDataResult<List<UserImage>> GetDefaultImage(int userId)
        {
            List<UserImage> userImage = new List<UserImage>();
            userImage.Add(new UserImage { Date = DateTime.Now, Id = userId, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<UserImage>>(userImage);
        }


    }
}
