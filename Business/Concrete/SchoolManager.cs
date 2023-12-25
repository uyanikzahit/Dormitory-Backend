﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
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
    public class SchoolManager : ISchoolService
    {
        ISchoolDal _schoolDal;

        public SchoolManager(ISchoolDal schoolDal)
        {
            _schoolDal = schoolDal;
        }

        [ValidationAspect(typeof(SchoolValidator))]
        [SecuredOperation("admin")]
        public IResult Add(School school)
        {
            _schoolDal.Add(school);
            return new SuccessResult(Messages.SchoolAdded);
        }

        public IDataResult<List<School>> GetAll()
        {
      
            return new SuccessDataResult<List<School>>(_schoolDal.GetAll(),Messages.SchoolsListed);
        }
        public IDataResult<School> GetShcoolById(int schoolId)
        {
            return new SuccessDataResult<School>(_schoolDal.Get(b => b.SchoolId ==schoolId),(Messages.SchoolListed));
        }

        public IResult Remove(School school)
        {
            _schoolDal.Delete(school);
            return new SuccessResult(Messages.SchoolDeleted);
        }

        [ValidationAspect(typeof(SchoolValidator))]
        [SecuredOperation("admin")]
        public IResult Update(School school)
        {
            _schoolDal.Update(school);
            return new SuccessResult(Messages.SchoolUpdated);
        }
    }
}
