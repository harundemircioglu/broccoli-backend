using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class FavoritesSuggestionController : BaseCRUDController<FavoritesSuggestion, int, FavoritesSuggestionCreateDto, FavoritesSuggestionUpdateDto, FavoritesSuggestionResponseDto>
    {
        public FavoritesSuggestionController(IFavoritesSuggestionService service) : base(service)
        {
        }
    }
}
