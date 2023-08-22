using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data.Postgres.EntityFramework;

public class PostgresContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new RecommendedPostsImageConfiguration());
        modelBuilder.ApplyConfiguration(new RecommendedPostConfiguration());
        modelBuilder.ApplyConfiguration(new FavoritesRecommendedPostConfiguration());
        modelBuilder.ApplyConfiguration(new WeightsTrackingConfiguration());
        modelBuilder.ApplyConfiguration(new SuggestionsImageConfiguration());
        modelBuilder.ApplyConfiguration(new SuggestionConfiguration());
        modelBuilder.ApplyConfiguration(new FavoritesSuggestionConfiguration());
        modelBuilder.ApplyConfiguration(new FavoritesPostConfiguration());
        modelBuilder.ApplyConfiguration(new PostConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new PostsImageConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (_configuration["EnvironmentAlias"] == "DEV")
        {
            optionsBuilder.LogTo(Console.Write);
        }
    }

    public DbSet<User> User => Set<User>();
    public DbSet<RecommendedPostsImage> RecommendedPostsImage => Set<RecommendedPostsImage>();
    public DbSet<RecommendedPost> RecommendedPost => Set<RecommendedPost>();
    public DbSet<FavoritesRecommendedPost> FavoritesRecommendedPost => Set<FavoritesRecommendedPost>();
    public DbSet<WeightsTracking> WeightsTracking => Set<WeightsTracking>();
    public DbSet<SuggestionsImage> SuggestionsImage => Set<SuggestionsImage>();
    public DbSet<Suggestion> Suggestion => Set<Suggestion>();
    public DbSet<FavoritesSuggestion> FavoritesSuggestion => Set<FavoritesSuggestion>();
    public DbSet<FavoritesPost> FavoritesPost => Set<FavoritesPost>();
    public DbSet<Post> Post => Set<Post>();
    public DbSet<Comment> Comment => Set<Comment>();
    public DbSet<PostsImage> PostsImage => Set<PostsImage>();
    public DbSet<Category> Category => Set<Category>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();
}