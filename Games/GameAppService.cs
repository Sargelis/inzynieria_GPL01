using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LAB.Games.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LAB.Games
{
    public class GameAppService : AsyncCrudAppService<Game, GameDto, long, PagedGameResultRequestDto, GameDto, GameDto>, IGameAppService
    {
        public GameAppService(IRepository<Game, long> repository) : base(repository)
        {
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public override Task<PagedResultDto<GameDto>> GetAllAsync(PagedGameResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

    }
}