using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Shops.Dto
{
    [AutoMapFrom(typeof(Shop))]
    public class ShopDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
