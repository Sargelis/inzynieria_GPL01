using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using LAB.Shops;

namespace LAB.Games
{
    public class Game : Entity<long>, ISoftDelete, IHasCreationTime
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
        public long ShopID { get; set; }
        public Shop Shop { get; set; }
    }
}
