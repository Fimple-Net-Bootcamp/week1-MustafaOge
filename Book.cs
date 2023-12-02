using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafa_oge_homework_1
{
    class Book : PrintedWorks, IPrintable
    {
        private int pageCount;
        private string genre;
        private string language;

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Kitap Bilgileri:");
            Console.WriteLine($"Başlık: {Title}");
            Console.WriteLine($"Yazar: {Author}");
            Console.WriteLine($"Yayın Yılı: {PublicationYear}");
            Console.WriteLine($"Kitap ID: {BookID}");
            Console.WriteLine($"Sayfa Sayısı: {PageCount}");
            Console.WriteLine($"Tür: {Genre}");
            Console.WriteLine($"Dil: {Language}");
            Console.WriteLine(); 
        }
    }

}
