using Abp.Application.Services.Dto;

namespace LAB.Games.Dto
{
    public class PagedGameResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

