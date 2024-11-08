﻿
namespace Library_Console_App
{
    public class Book
    {
        public int BookID { get; set; }
        public int ISBN { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int PublishingYear { get; set; }
        public List<int> Rating { get; set; } = new List<int>();
        public Book(int bookid,int isbn, string title, string author, string genre, int publishingyear, List<int> rating)
        {
            BookID = bookid;
            ISBN = isbn;
            Title = title;
            Author = author;
            Genre = genre;
            PublishingYear = publishingyear;
            Rating = rating;
        }

        public double GetAverageRating()
        {
            if (Rating.Count == 0)
                return 0;
            else
            {
                return Rating.Average();
            }
        }
    }
}
