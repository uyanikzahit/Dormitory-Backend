using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
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

        public UserImageManager(IUserImageDal userImageDal, IFileHelper fileHelper)
        {
            _userImageDal = userImageDal;
            _fileHelper = fileHelper;
        }

        public IResult Add(IFormFile file, UserImage userImage)
        {
            IResult result = BusinessRules.Run(CheckIfUserImageLimit(userImage.Id));
            if (result != null)
            {
                return result;
            }
            userImage.ImagePath = _fileHelper.Upload(file, PathConstants.ImagePath);
            userImage.Date = DateTime.Now;
            _userImageDal.Add(userImage);
            return new SuccessResult(Messages.UserImageAdded);
        }

        public IResult Delete(UserImage userImage)
        {
            _fileHelper.Delete(PathConstants.ImagePath + userImage.ImagePath);
            _userImageDal.Delete(userImage);
            return new SuccessResult(Messages.UserImageDeleted);
        }

        public IDataResult<List<UserImage>> GetAll()
        {
            return new SuccessDataResult<List<UserImage>>(_userImageDal.GetAll());

        }

        public IDataResult<UserImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<UserImage>(_userImageDal.Get(c => c.Id == imageId));

        }

        public IDataResult<List<UserImage>> GetByUserId(int userId)
        {
            var result = BusinessRules.Run(CheckUserImageExists(userId));
            if (result != null)
            {
                return new ErrorDataResult<List<UserImage>>(GetDefaultImage(userId).Data);
            }
            return new SuccessDataResult<List<UserImage>>(_userImageDal.GetAll(u => u.Id == userId));
        }

        public IResult Update(IFormFile file, UserImage userImage)
        {
            userImage.ImagePath = _fileHelper.Update(file, PathConstants.ImagePath + userImage.ImagePath, PathConstants.ImagePath);
            userImage.Date = DateTime.Now;
            _userImageDal.Update(userImage);
            return new SuccessResult(Messages.UserImageUpdated);
        }



        //İş kuralları

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
