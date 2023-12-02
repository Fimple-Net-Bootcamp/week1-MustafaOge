using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafa_oge_homework_1
{
    class Member : IPrintable
    {
        private string firstName;
        private string lastName;
        private int membershipNumber;
        private List<Book> borrowedBooks = new List<Book>();

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int MembershipNumber
        {
            get { return membershipNumber; }
            set { membershipNumber = value; }
        }

        public List<Book> BorrowedBooks
        {
            get { return borrowedBooks; }
            set { borrowedBooks = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Üye Bilgileri:");
            Console.WriteLine($"Ad: {FirstName}");
            Console.WriteLine($"Soyad: {LastName}");
            Console.WriteLine($"Üyelik Numarası: {MembershipNumber}");
            Console.WriteLine();
        }
    }

}
