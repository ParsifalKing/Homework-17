using Domain.Models;
using Infrastructure.Services;

// Post
var post1 = new Post();
post1.Id = 1;
post1.Title = "C# course";
post1.Description = "I am learning";
post1.CreatedAt = (DateTime.Now);
post1.CategoryId = 1;

var post2 = new Post();
post2.Id = 2;
post2.Title = "C# course";
post2.Description = "I will finish";
post2.CreatedAt = new(2024, 01, 13);
post2.CategoryId = 2;

PostService.CreatePost(post1);
PostService.CreatePost(post2);

PostService.GetPostByName(post1.Title);
PostService.GetPostById(post1.Id);
PostService.GetPostByDate(post1.CreatedAt);

System.Console.WriteLine("            POSTS");
foreach (var item in PostService.GetPost())
{
    System.Console.WriteLine("Id = " + item.Id);
    System.Console.WriteLine("Title = " + item.Title);
    System.Console.WriteLine("Description = " + item.Description);
    System.Console.WriteLine("Date = " + item.CreatedAt);
    System.Console.WriteLine("CategoryId = " + item.CategoryId);
    System.Console.WriteLine("---------------------");
}

PostService.DeletePost(post1.Id);
System.Console.WriteLine();

foreach (var item in PostService.GetPost())
{
    System.Console.WriteLine("Id = " + item.Id);
    System.Console.WriteLine("Title = " + item.Title);
    System.Console.WriteLine("Description = " + item.Description);
    System.Console.WriteLine("Date = " + item.CreatedAt);
    System.Console.WriteLine("CategoryId = " + item.CategoryId);
    System.Console.WriteLine("---------------------");
}



// Category

var category1 = new Category();
category1.Id = 1;
category1.Name = " Khit ";
category1.CreatedAt = (DateTime.Now);


var category2 = new Category();
category2.Id = 2;
category2.Name = "Brend";
category2.CreatedAt = new(2024, 01, 13);

CategoryService.CreateCategory(category1);
CategoryService.CreateCategory(category2);


System.Console.WriteLine("            CATEGORIES");
foreach (var item in CategoryService.GetCategory())
{
    System.Console.WriteLine("Id = " + item.Id);
    System.Console.WriteLine("Name = " + item.Name);
    System.Console.WriteLine("Date = " + item.CreatedAt);
    System.Console.WriteLine("---------------------");
}


CategoryService.DeleteCategory(category2.Id);
System.Console.WriteLine();


foreach (var item in CategoryService.GetCategory())
{
    System.Console.WriteLine("Id = " + item.Id);
    System.Console.WriteLine("Name = " + item.Name);
    System.Console.WriteLine("Date = " + item.CreatedAt);
    System.Console.WriteLine("---------------------");
}



