using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserImageService
    {
        IResult Add(IFormFile file, UserImage userImage);
        IResult Delete(UserImage userImage);
        IResult Update(IFormFile file, UserImage userImage);
        IDataResult<List<UserImage>> GetAll();
        IDataResult<UserImage> GetByImageId(int imageId);
        IDataResult<List<UserImage>> GetByUserId(int userId);
        IDataResult<List<UserImageDetailDto>> GetUserImageDetails();

    }
}
