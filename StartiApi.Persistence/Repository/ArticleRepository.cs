using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StartiApi.Domain.Domain.Entities;
using StartiApi.Repositories;

public class ArticleRepository : IArticleRepository
{
    public Task<IEnumerable<Article>> GetAsync()
    {
        var articles = new List<Article>
        {
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Introduction to Programming",
                Content = "This article covers the basics of programming, including what programming is and why it is important.",
                Author = "Jane Doe",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Getting Started with Python",
                Content = "Learn how to set up your development environment and write your first Python program.",
                Author = "John Smith",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Understanding Variables and Data Types",
                Content = "This article explains variables and data types in programming, with examples in various languages.",
                Author = "Alice Johnson",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Introduction to Control Flow",
                Content = "Learn about if statements, loops, and how they control the flow of your program.",
                Author = "Michael Brown",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Functions and Methods",
                Content = "An introduction to functions and methods, including how to define and call them in your code.",
                Author = "Emily Davis",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Getting Started with JavaScript",
                Content = "Learn the basics of JavaScript and how to write your first web-based programs.",
                Author = "David Wilson",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Introduction to Object-Oriented Programming",
                Content = "This article covers the principles of object-oriented programming and provides examples in various languages.",
                Author = "Chris Miller",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Understanding Arrays and Lists",
                Content = "Learn about arrays and lists, including how to use them to store and manipulate collections of data.",
                Author = "Patricia Taylor",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Getting Started with HTML and CSS",
                Content = "An introduction to HTML and CSS for building simple web pages.",
                Author = "Linda Anderson",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            },
            new Article
            {
                Id = Guid.NewGuid().ToString(),
                Title = "Introduction to Debugging",
                Content = "Learn how to debug your programs, including common tools and techniques.",
                Author = "Mark Thomas",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            }
        };

        return Task.FromResult((IEnumerable<Article>)articles);
    }

    public Task<IEnumerable<Article>> GetAsyncBy(string name, string email = "")
    {
        throw new NotImplementedException();
    }
}
