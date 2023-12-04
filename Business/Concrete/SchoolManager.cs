using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SchoolManager : ISchoolService
    {
        ISchoolService _schoolService;

        public SchoolManager(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        public IResult Add(School school)
        {
            _schoolService.Add(school);
            return new SuccessResult(Messages.SchoolAdded);
        }

        public IDataResult<List<School>> GetAll()
        {
            
            return new SuccessDataResult<List<School>>(_schoolService.GetAll());

        }

        public IDataResult<School> GetShcoolById(int schoolId)
        {
            throw new NotImplementedException();
        }

        public IResult Remove(School school)
        {
            _schoolService.Remove(school);
            return new SuccessResult(Messages.SchoolDeleted);
        }

        public IResult Update(School school)
        {
            _schoolService.Update(school);
            return new SuccessResult(Messages.SchoolDeleted);
        }
    }
}
