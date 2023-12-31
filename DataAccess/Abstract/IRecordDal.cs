﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRecordDal : IEntityRepository<Record>
    {
        List<RecordDetailDto> GetRecordDetails(Expression<Func<RecordDetailDto, bool>> filter = null);
        List<RecordDetailDto> GetRecordByUserAndActivity(int userId, int activityId);

    }
}
