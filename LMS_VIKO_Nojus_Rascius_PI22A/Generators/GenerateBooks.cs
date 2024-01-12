using LMS_VIKO_Nojus_Rascius_PI22A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.Generators
{
    public class GenerateBooks : IGenerator<Book>
    {
        public List<Book> GetGenerateItems()
        {
            var books = new List<Models.Book>();
            for (int i = 1; i <= 50; i++)
            {
                books.Add(new Models.Book
                {
                    Id = i,
                    Title = $"Title {i}",
                    Author = $"The Journey of Time {i}",
                    Publisher = $"Author Name {i}"
                });
            }
            return books;
        }
    }
}
