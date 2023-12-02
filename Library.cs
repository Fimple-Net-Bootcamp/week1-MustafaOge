using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafa_oge_homework_1
{

    class Library : IPrintable
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void Remove(int bookID)
        {
            Book bookToRemove = books.Find(b => b.BookID == bookID);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine("Üye Eklendi : " + member.FirstName);
        }

        public void LendBook(Member member, Book book, bool shortTermLoan)


        {

            if (shortTermLoan)
            {
                Console.WriteLine($"Book '{book.Title}' lent for a short term.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' lent for a long term.");
            }

            member.BorrowedBooks.Add(book);
        }

        public void PrintMembers()
        {
            Console.WriteLine("\nÜyelerin Bilgileri:");
            foreach (var member in members)
            {
                if (member is IPrintable printableMember)
                {
                    printableMember.Print();
                }
            }
        }


        public void PrintLibrary()
        {
            Console.WriteLine("Library Information:");

            foreach (var book in books)
            {
                if (book is IPrintable printableBook)
                {
                    printableBook.Print();
                }
            }

        }

        public void Print()
        {
            PrintMembers();
        }
    }
}
