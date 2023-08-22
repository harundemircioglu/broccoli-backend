using Business.Services;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interface;
using Business.Utilities.Security.Auth.Jwt;
using Business.Utilities.Security.Auth.Jwt.Interface;
using Business.Utilities.Validation;
using Business.Utilities.Validation.Interface;
using Core.Utilities.Mail;
using Infrastructure.Data.Postgres;

namespace Web.Utilities;

public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddScoped<IClaimHelper, ClaimHelper>();
        serviceCollection.AddScoped<IAuthService, AuthService>();
        serviceCollection.AddScoped<ICategoryService, CategoryService>();
        serviceCollection.AddScoped<ICommentService, CommentService>();
        serviceCollection.AddScoped<IFavoritesPostService, FavoritesPostService>();
        serviceCollection.AddScoped<IFavoritesRecommendedPostService, FavoritesRecommendedPostService>();
        serviceCollection.AddScoped<IFavoritesSuggestionService, FavoritesSuggestionService>();
        serviceCollection.AddScoped<IPostService, PostService>();
        serviceCollection.AddScoped<IPostsImageService, PostsImageService>();
        serviceCollection.AddScoped<IRecommendedPostService, RecommendedPostService>();
        serviceCollection.AddScoped<IRecommendedPostsImageService, RecommendedPostsImageService>();
        serviceCollection.AddScoped<ISuggestionService, SuggestionService>();
        serviceCollection.AddScoped<ISuggestionsImageService, SuggestionsImageService>();
        serviceCollection.AddScoped<IUserService, UserService>();
        serviceCollection.AddScoped<IWeightsTrackingService, WeightsTrackingService>();
    }

    public static void AddMySingleton(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
        serviceCollection.AddSingleton<IMailHelper, MailHelper>();
    }

    public static void AddMyTransient(this IServiceCollection serviceCollection)
    {
    }
}