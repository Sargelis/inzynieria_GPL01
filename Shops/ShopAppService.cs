using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LAB.Shops.Dto;
using System.Threading.Tasks;

namespace LAB.Shops
{
    public class ShopAppService : AsyncCrudAppService<Shop, ShopDto, long, PagedShopResultRequestDto, ShopDto, ShopDto>, IShopAppService
    {
        public ShopAppService(IRepository<Shop, long> repository) : base(repository)
        {
        }

        public override Task<PagedResultDto<ShopDto>> GetAllAsync(PagedShopResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }
    }
}