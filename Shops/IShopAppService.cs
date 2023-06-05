using Abp.Application.Services;
using LAB.Shops.Dto;

namespace LAB.Shops
{
    public interface IShopAppService : IAsyncCrudAppService<ShopDto, long, PagedShopResultRequestDto, ShopDto, ShopDto>
    {

    }
}