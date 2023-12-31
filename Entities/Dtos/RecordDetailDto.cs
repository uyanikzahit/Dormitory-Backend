﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class RecordDetailDto : IDto
    {
        public RecordDetailDto()
        {
            Date = DateTime.Now;
        }

        public int RecordId { get; set; }
        public string RecordName { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }

    }
}
