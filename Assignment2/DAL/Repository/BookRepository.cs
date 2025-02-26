
namespace MoodleAssignment2_Functions.DAL.Repository
{
    public class BookRepository
    {
        public void Save(Book book)
        {
            string filename = $"/documents/{book.Title} - {book.Author}.txt";
            File.WriteAllText(filename, book.Title + " by " + book.Author);
        }
    }
}
