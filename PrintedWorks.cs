using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafa_oge_homework_1
{
    public class PrintedWorks
    {
        private string title;
        private string author;
        private int publicationYear;
        private int bookID;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }

        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
    }
}
