using Abp.Application.Services.Dto;

namespace LAB.Shops.Dto
{
    public class PagedShopResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

