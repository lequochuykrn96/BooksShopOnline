using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.Entity;

namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Fiction"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Biographies and Memoirs"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Biological Sciences"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Self-Help"
                }
            };
            return categories;
        }
        private static List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book
                {
                    BookID = 1,
                    BookName = "Fire & Blood",
                    Description = "300 Years Before A Game of Thrones (A Targaryen History) (A Song of Ice and Fire).",
                    ImagePath ="Pic1.png",
                    UnitPrice = 16.04f,
                    CategoryID = 1
                    },
                new Book
                {
                    BookID = 2,
                    BookName = "Benjamin Franklin: An American Life",
                    Description = "In this authoritative and engrossing full-scale biography, Walter Isaacson, " + "bestselling author of Einstein and Steve Jobs, shows how the most fascinating of " + "America's founders helped define our national character.",
                    ImagePath ="Pic2.png",
                    UnitPrice = 19.60f,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 3,
                    BookName = "Obama: An Intimate Portrait",
                    Description = "During Barack Obama's two terms, Pete Souza was with the President " + "during more crucial moments than anyone else--and he photographed them all",
                    ImagePath ="Pic3.png",
                    UnitPrice = 26.73f,
                    CategoryID = 2
                },
                new Book
                {
                    BookID = 4,
                    BookName = "Sapiens: A Brief History of Humankind",
                    Description = "One hundred thousand years ago, at least six different species of " + "humans inhabited Earth. Yet today there is only one—homo sapiens. " + "What happened to the others? And what may happen to us?",
                    ImagePath ="Pic4.png",
                    UnitPrice = 23.79f,
                    CategoryID = 3
                },
                new Book
                {
                    BookID = 5,
                    BookName = "The 7 Habits of Highly Effective People",
                    Description = "Stephen Covey’s cherished classic commemorates the timeless wisdom and " + "power of the 7 Habits book, and does it in a highly readable and understandable, infographics format.",
                    ImagePath ="Pic5.png",
                    UnitPrice = 16.04f,
                    CategoryID = 4
                },


            };
            return books;
        }
    }
}