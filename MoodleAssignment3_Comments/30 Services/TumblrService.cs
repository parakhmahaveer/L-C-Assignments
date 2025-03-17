using MoodleAssignment3_Comments.Models;
using MoodleAssignment3_Comments.Helpers;

namespace MoodleAssignment3_Comments.Services
{
    internal class TumblrService : ITumblrService
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task FetchAndDisplayBlogData(string blogName, int start, int num)
        {
            string apiUrl = $"https://{blogName}.tumblr.com/api/read/json?type=photo&num={num}&start={start}";
            try
            {
                string response = await client.GetStringAsync(apiUrl);
                BlogInfo blogInfo = TumblrApiHelper.ParseBlogInfo(response);
                List<TumblrPost> posts = TumblrApiHelper.ParseTumblrPosts(response);

                Console.WriteLine("\nTitle: " + blogInfo.Title);
                Console.WriteLine("Name: " + blogInfo.Name);
                Console.WriteLine("Description: " + blogInfo.Description);
                Console.WriteLine("Total Posts: " + blogInfo.TotalPosts);

                int postNumber = start + 1;
                foreach (var post in posts)
                {
                    Console.WriteLine($"\n{postNumber}.");
                    foreach (string url in post.ImageUrls)
                    {
                        Console.WriteLine(url);
                    }
                    postNumber++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching data: " + ex.Message);
            }
        }


    }
}
