using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace LAB.Games.Dto
{
    [AutoMapFrom(typeof(Game))]
    public class GameDto : EntityDto<long>
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
