using MoodleAssignment3_Comments.Services;

namespace MoodleAssignment3_Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Tumblr blog name: ");
            string blogName = Console.ReadLine();

            Console.Write("Enter the post range (start-end): ");
            string rangeInput = Console.ReadLine();

            // Validate range input
            string[] rangeParts = rangeInput.Split('-');
            if (rangeParts.Length != 2 || !int.TryParse(rangeParts[0], out int start) || !int.TryParse(rangeParts[1], out int end) || start < 1 || end < start)
            {
                Console.WriteLine("Invalid range. Please enter a valid range (e.g., 1-5).");
                return;
            }

            ITumblrService tumblrService = new TumblrService();
            tumblrService.FetchAndDisplayBlogData(blogName, start - 1, end - start + 1);
        }
    }
}