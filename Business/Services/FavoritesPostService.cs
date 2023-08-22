using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class FavoritesPostService : BaseService<FavoritesPost, int, FavoritesPostResponseDto>, IFavoritesPostService
    {
        protected readonly IFavoritesPostRepository _repository; // Değişiklik burada
        public FavoritesPostService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) : base(unitOfWork, unitOfWork.FavoritesPosts, mapperHelper)
        {
            _repository = unitOfWork.FavoritesPosts;
        }
        public async Task<IList<FavoritesPostResponseDto>> GetByUserIdAsync(int userId)
        {
            var favoritesPosts = await _repository.GetByUserIdAsync(userId);
            var responseDtos = _mapperHelper.Map<IList<FavoritesPostResponseDto>>(favoritesPosts);
            return responseDtos;
        }
    }
}
