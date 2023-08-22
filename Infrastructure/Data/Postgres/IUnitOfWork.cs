using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IWeightsTrackingRepository WeightsTrackings { get; }
    IPostRepository Posts { get; }
    ICommentRepository Comments { get; }
    IFavoritesPostRepository FavoritesPosts { get; }
    IPostsImageRepository PostsImages { get; }
    ICategoryRepository Categories { get; }
    ISuggestionRepository Suggestions { get; }
    ISuggestionsImageRepository SuggestionsImages { get; }
    IFavoritesSuggestionRepository FavoritesSuggestions { get; }
    IRecommendedPostRepository RecommendedPosts { get; }
    IRecommendedPostsImageRepository RecommendedPostsImages { get; }
    IFavoritesRecommendedPostRepository FavoritesRecommendedPosts { get; }
    Task<int> CommitAsync();
}