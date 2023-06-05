using Abp.Application.Services;
using LAB.Games.Dto;

namespace LAB.Games
{
    public interface IGameAppService : IAsyncCrudAppService<GameDto, long, PagedGameResultRequestDto, GameDto, GameDto>
    {

    }
}