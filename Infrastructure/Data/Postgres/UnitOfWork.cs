using Core.Utilities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;

    private UserRepository? _userRepository;
    private UserTokenRepository? _userTokenRepository;
    private WeightsTrackingRepository? _weightsTrackingRepository;
    private PostRepository? _postRepository;
    private CommentRepository? _commentRepository;
    private FavoritesPostRepository? _favoritesPostRepository;
    private PostsImageRepository? _postsImageRepository;
    private CategoryRepository? _categoryRepository;
    private RecommendedPostRepository? _recommendedPostRepository;
    private RecommendedPostsImageRepository? _recommendedPostsImageRepository;
    private FavoritesRecommendedPostRepository? _favoritesRecommendedPostRepository;
    private SuggestionRepository? _suggestionRepository;
    private SuggestionsImageRepository? _suggestionsImageRepository;
    private FavoritesSuggestionRepository? _favoritesSuggestionRepository;

    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }

    public IUserRepository Users => _userRepository ??= new UserRepository(_postgresContext);
    public IUserTokenRepository UserTokens => _userTokenRepository ??= new UserTokenRepository(_postgresContext);
    public IWeightsTrackingRepository WeightsTrackings => _weightsTrackingRepository ??= new WeightsTrackingRepository(_postgresContext);
    public IPostRepository Posts => _postRepository ??= new PostRepository(_postgresContext);
    public ICommentRepository Comments => _commentRepository ??= new CommentRepository(_postgresContext);
    public IFavoritesPostRepository FavoritesPosts => _favoritesPostRepository ??= new FavoritesPostRepository(_postgresContext);
    public IPostsImageRepository PostsImages => _postsImageRepository ??= new PostsImageRepository(_postgresContext);
    public ICategoryRepository Categories => _categoryRepository ??= new CategoryRepository(_postgresContext);
    public ISuggestionRepository Suggestions => _suggestionRepository ??= new SuggestionRepository(_postgresContext);
    public ISuggestionsImageRepository SuggestionsImages => _suggestionsImageRepository ??= new SuggestionsImageRepository(_postgresContext);
    public IFavoritesSuggestionRepository FavoritesSuggestions => _favoritesSuggestionRepository ??= new FavoritesSuggestionRepository(_postgresContext);
    public IRecommendedPostRepository RecommendedPosts => _recommendedPostRepository ??= new RecommendedPostRepository(_postgresContext);
    public IRecommendedPostsImageRepository RecommendedPostsImages => _recommendedPostsImageRepository ??= new RecommendedPostsImageRepository(_postgresContext);
    public IFavoritesRecommendedPostRepository FavoritesRecommendedPosts => _favoritesRecommendedPostRepository ??= new FavoritesRecommendedPostRepository(_postgresContext);

    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);

        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToTimeZone();
        }

        var result = await _postgresContext.SaveChangesAsync();

        return result;
    }

    public void Dispose()
    {
        _postgresContext.Dispose();
    }
}