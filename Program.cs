// See https://aka.ms/new-console-template for more information
using mustafa_oge_homework_1;


Book book1 = new Book { Title = "Suç ve Ceza", Author = "Fyodor Dostoyevski", PublicationYear = 1866, BookID = 1, PageCount = 704, };
Book book2 = new Book { Title = "Beyaz Zambaklar Ülkesinde", Author = "Grigoriy Petrov", PublicationYear = 1923, BookID = 2, PageCount = 256, };


Member member1 = new Member { FirstName = "Ahmet", LastName = "Demir", MembershipNumber = 101 };
Member member2 = new Member { FirstName = "Elif", LastName = "Yilmaz", MembershipNumber = 102 };


Library library = new Library();

library.Add(book1);
library.Add(book2);

library.AddMember(member1);
library.AddMember(member2);

library.PrintMembers();
library.PrintLibrary();


library.LendBook(member1, book1, shortTermLoan: true);
library.LendBook(member2, book2, shortTermLoan: false);

Console.ReadLine();

book1.Print();
book2.Print();

library.Print();