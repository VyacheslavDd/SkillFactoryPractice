using EntityFrameworkFinalTask.Core;
using EntityFrameworkFinalTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkFinalTask.Repositories
{
    public class BookRepository
    {
        private LibraryContext context;

        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public List<Book?> SelectAll()
        {
            return context.Books.ToList();
        }

        public void AddBook(Book book)
        {
            context.Books.Add(book);
        }

        public void RemoveUser(Book book)
        {
            context.Books.Remove(book);
        }

        public void UpdateYearById(int id, int  year)
        {
            var book = SelectBookById(id);
            if (book is not null)
                book.ReleaseYear = year;
        }

        public Book? SelectBookById(int id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }

        public List<Book> GetBooksBetweenYears(int from, int to)
        {
            return context.Books.Where(b => b.ReleaseYear >= from && b.ReleaseYear <= to).ToList();
        }

        public int GetBooksAmountByAuthor(Author author)
        {
            return context.Books.Count(b => b.AuthorId == author.Id);
        }

        public int GetBooksAmountByGenre(string genre)
        {
            return context.Books.Count(b => b.Genre == genre);
        }

        public bool IsBookInLibrary(Author author, string bookTitle)
        {
            return context.Books.Any(b => b.Title == bookTitle && b.AuthorId == author.Id);
        }
        public bool HasUserBook(User user, string bookTitle)
        {
            return context.Books.Any(b => b.Title == bookTitle && b.UserId == user.Id);
        }
        public int GetBooksAmountByUser(User user)
        {
            return context.Books.Count(b => b.UserId == user.Id);
        }
        public Book GetLatestBook()
        {
            var latestYear = context.Books.Max(b => b.ReleaseYear);
            return context.Books.FirstOrDefault(b => b.ReleaseYear == latestYear);
        }
        public List<Book> GetBooksSortedByTitle()
        {
            return context.Books.Select(b => b).OrderBy(b => b.Title).ToList();
        }
        public List<Book> GetBooksSortedByYearDecreasing()
        {
            return context.Books.Select(b => b).OrderByDescending(b => b.ReleaseYear).ToList();
        }
    }
}
