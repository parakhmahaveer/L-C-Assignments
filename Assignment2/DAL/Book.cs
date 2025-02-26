

namespace MoodleAssignment2_Functions.DAL
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        private int CurrentPage { get; set; } = 1;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void TurnPage()
        {
            CurrentPage++;
        }

        public string GetCurrentPage()
        {
            return $"Content of page {CurrentPage}";
        }
    }
}
