using Domain.Models;

namespace Infrastructure.Services;

public class CategoryService
{

    static List<Category> categories = new List<Category>();

    public static void CreateCategory(Category category)
    {
        categories.Add(category);
    }
    public static List<Category> GetCategory()
    {
        return categories;
    }
    public static Category GetCategoryById(int id)
    {
        var category = categories.FirstOrDefault(e => e.Id == id);
        return category;
    }
    public static Category GetCategoryByName(string name)
    {
        var category = categories.FirstOrDefault(e => e.Name == name);
        return category;
    }
    public static List<Category> GetCategoryByDate(DateTime date)
    {
        var category = categories.Where(e => e.CreatedAt == date).ToList();
        return category;
    }
    public static List<Category> GetCategoryByCategoryId(int id)
    {
        var category = categories.Where(e => e.Id == id).ToList();
        return category;
    }
    public static void DeleteCategory(int id)
    {
        var category = categories.FirstOrDefault(e => e.Id == id);
        categories.Remove(category);
    }



}
