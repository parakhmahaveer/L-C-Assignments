using MoodleAssignment3_Comments.Models;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace MoodleAssignment3_Comments.Helpers
{
    internal class TumblrApiHelper
    {
        public static BlogInfo ParseBlogInfo(string jsonResponse)
        {
            string cleanJson = Regex.Match(jsonResponse, @"(?<=\{).*?(?=\};)", RegexOptions.Singleline).Value;
            cleanJson = "{" + cleanJson + "}";

            using JsonDocument doc = JsonDocument.Parse(cleanJson);
            JsonElement root = doc.RootElement;

            return new BlogInfo
            {
                Title = root.GetProperty("tumblr").GetProperty("title").GetString(),
                Description = root.GetProperty("tumblr").GetProperty("description").GetString(),
                Name = root.GetProperty("tumblr").GetProperty("name").GetString(),
                TotalPosts = root.GetProperty("tumblr").GetProperty("posts-total").GetInt32()
            };
        }

        public static List<TumblrPost> ParseTumblrPosts(string jsonResponse)
        {
            List<TumblrPost> posts = new List<TumblrPost>();
            // Extract JSON content using regex

            string cleanJson = Regex.Match(jsonResponse, @"(?<=\{).*?(?=\};)", RegexOptions.Singleline).Value;
            cleanJson = "{" + cleanJson + "}";

            using JsonDocument doc = JsonDocument.Parse(cleanJson);
            JsonElement root = doc.RootElement;
            JsonElement postsElement = root.GetProperty("posts");

            foreach (JsonElement post in postsElement.EnumerateArray())
            {
                List<string> imageUrls = new List<string>();
                if (post.TryGetProperty("photos", out JsonElement photos))
                {
                    foreach (JsonElement photo in photos.EnumerateArray())
                    {
                        if (photo.TryGetProperty("photo-url-1280", out JsonElement photoUrl))
                        {
                            imageUrls.Add(photoUrl.GetString());
                        }
                    }
                }
                if (imageUrls.Count > 0)
                {
                    posts.Add(new TumblrPost { ImageUrls = imageUrls });
                }
            }
            return posts;
        }
    }
}
