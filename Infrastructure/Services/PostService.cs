using Domain.Models;

namespace Infrastructure.Services;

public static class PostService
{

    static List<Post> posts = new List<Post>();

    public static void CreatePost(Post post)
    {
        posts.Add(post);
    }
    public static List<Post> GetPost()
    {
        return posts;
    }
    public static Post GetPostById(int id)
    {
        var post = posts.FirstOrDefault(e => e.Id == id);
        return post;
    }
    public static Post GetPostByName(string name)
    {
        var post = posts.FirstOrDefault(e => e.Title == name);
        return post;
    }
    public static List<Post> GetPostByDate(DateTime date)
    {
        var post = posts.FirstOrDefault(e => e.CreatedAt == date);
        return posts;

    }
    public static List<Post> GetPostByCategoryId(int id)
    {
        var post = posts.FirstOrDefault(e => e.Id == id);
        return posts;
    }
    public static void DeletePost(int id)
    {
        var post = posts.FirstOrDefault(e => e.Id == id);
        posts.Remove(post);

    }



}
