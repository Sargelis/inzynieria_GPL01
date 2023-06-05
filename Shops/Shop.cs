﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LAB.Authorization.Users;

namespace LAB.Shops
{
    public class Shop : Entity<long>, ISoftDelete, IHasCreationTime
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long UserID { get; set; }
        public User User { get; set; }
    }
}
