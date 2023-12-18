using Business.Abstract;
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
            
        }

        public IResult Delete(UserImage userImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserImage> GetByImageId(int imageId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserImage>> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IFormFile file, UserImage userImage)
        {
            throw new NotImplementedException();
        }
    }
}
