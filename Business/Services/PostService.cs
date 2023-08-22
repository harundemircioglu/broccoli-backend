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
    public class PostService : BaseService<Post, int, PostResponseDto>, IPostService
    {
        protected readonly IPostRepository _repository; // Değişiklik burada
        public PostService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) : base(unitOfWork, unitOfWork.Posts, mapperHelper)
        {
            _repository = unitOfWork.Posts;
        }
        public async Task<IList<PostResponseDto>> GetByUserIdAsync(int userId)
        {
            var posts = await _repository.GetByUserIdAsync(userId);
            var responseDtos = _mapperHelper.Map<IList<PostResponseDto>>(posts);
            return responseDtos;
        }
    }
}
