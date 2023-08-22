using Business.Models.Request.Functional;
using Business.Models.Request.Create;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Models.Request.Update;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {

        //USER
        CreateMap<RegisterDto, User>();
        CreateMap<UserUpdateDto, User>();
        CreateMap<User, UserProfileDto>();

        //WEIGHT TRACKINGS
        CreateMap<WeightsTrackingCreateDto, WeightsTracking>();
        CreateMap<WeightsTrackingUpdateDto, WeightsTracking>();
        CreateMap<WeightsTracking, WeightsTrackingResponseDto>();

        //POSTS
        CreateMap<PostCreateDto, Post>();
        CreateMap<PostUpdateDto, Post>();
        CreateMap<Post, PostResponseDto>();

        //FAVORITES POSTS
        CreateMap<FavoritesPostCreateDto, FavoritesPost>();
        CreateMap<FavoritesPostUpdateDto, FavoritesPost>();
        CreateMap<FavoritesPost, FavoritesPostResponseDto>();

        //POST IMAGES
        CreateMap<PostsImageCreateDto, PostsImage>();
        CreateMap<PostsImageUpdateDto, PostsImage>();
        CreateMap<PostsImage, PostsImageResponseDto>();

        //COMMENTS
        CreateMap<CommentCreateDto, Comment>();
        CreateMap<CommentUpdateDto, Comment>();
        CreateMap<Comment, CommentResponseDto>();

        //CATEGORIES
        CreateMap<CategoryCreateDto, Category>();
        CreateMap<CategoryUpdateDto, Category>();
        CreateMap<Category, CategoryResponseDto>();

        //SUGGESTIONS
        CreateMap<SuggestionCreateDto, Suggestion>();
        CreateMap<SuggestionUpdateDto, Suggestion>();
        CreateMap<Suggestion, SuggestionResponseDto>();

        //SUGGESTION IMAGES
        CreateMap<SuggestionsImageCreateDto, SuggestionsImage>();
        CreateMap<SuggestionsImageUpdateDto, SuggestionsImage>();
        CreateMap<SuggestionsImage, SuggestionsImageResponseDto>();

        //FAVORITES SUGGESTIONS
        CreateMap<FavoritesSuggestionCreateDto, FavoritesSuggestion>();
        CreateMap<FavoritesSuggestionUpdateDto, FavoritesSuggestion>();
        CreateMap<FavoritesSuggestion, FavoritesSuggestionResponseDto>();

        //RECOMMENDED POSTS
        CreateMap<RecommendedPostCreateDto, RecommendedPost>();
        CreateMap<RecommendedPostUpdateDto, RecommendedPost>();
        CreateMap<RecommendedPost, RecommendedPostResponseDto>();

        //RECOMMENDED POST IMAGES
        CreateMap<RecommendedPostsImageCreateDto, RecommendedPostsImage>();
        CreateMap<RecommendedPostsImageUpdateDto, RecommendedPostsImage>();
        CreateMap<RecommendedPostsImage, RecommendedPostsImageResponseDto>();

        //FAVORITES RECOMMENDED POSTS
        CreateMap<FavoritesRecommendedPostCreateDto, FavoritesRecommendedPost>();
        CreateMap<FavoritesRecommendedPostUpdateDto, FavoritesRecommendedPost>();
        CreateMap<FavoritesRecommendedPost, FavoritesRecommendedPostResponseDto>();
    }
}