using MoodleAssignment2_Functions.DAL;
using MoodleAssignment2_Functions.DAL.Repository;
using MoodleAssignment2_Functions.Printer;

namespace MoodleAssignment2_Functions
{
    public class BookManager
    {
        private readonly BookRepository _bookRepository;
        private readonly IPrinter _printer;

        public BookManager(BookRepository bookRepository, IPrinter printer)
        {
            _bookRepository = bookRepository;
            _printer = printer;
        }

        public void PrintCurrentPage(Book book)
        {
            try
            {
                string pageContent = book.GetCurrentPage();
                _printer.PrintPage(pageContent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveBook(Book book)
        {
            try
            {
                _bookRepository.Save(book);
                Console.WriteLine($"Book '{book.Title}' saved successfully.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AssignLibraryLocation(Book book, Placement location)
        {
            try
            {
                Console.WriteLine($"Book '{book.Title}' assigned to {location.GetLocation()}.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void TurnBookPage(Book book)
        {
            try
            {
                book.TurnPage();
                Console.WriteLine($"Turned to next page in '{book.Title}'.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
