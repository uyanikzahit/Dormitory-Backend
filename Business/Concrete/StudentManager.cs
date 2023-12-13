using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public IResult Add(Student student)
        {
            _studentDal.Add(student);
            return new SuccessResult(Messages.StudentAdded);
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.StudentDeleted);
        }

        public IDataResult<Student> GetById(int studentId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(c => c.StudentId == studentId),Messages.StudentListed);
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll(), Messages.StudenstListed);
        }

        public IDataResult<List<StudentDetailDto>> GetStudentDetails()
        {
            return new SuccessDataResult<List<StudentDetailDto>>(_studentDal.GetStudentDetails(), Messages.StudentsDetailsListed);

        }

        public IDataResult<List<StudentDetailDto>> GetStudentDetailsId(int studentId)
        {
            List<StudentDetailDto> studentDetails = _studentDal.GetStudentDetails(s => s.StudentId == studentId);
            if (studentDetails == null)
            {
                return new ErrorDataResult<List<StudentDetailDto>>("");
            }
            else
            {
                return new SuccessDataResult<List<StudentDetailDto>>(studentDetails, Messages.StudentDetailsListed);
            }
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.StudentUpdated);
        }
    }
}
