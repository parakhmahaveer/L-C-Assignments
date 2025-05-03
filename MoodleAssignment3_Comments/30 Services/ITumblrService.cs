
namespace MoodleAssignment3_Comments.Services
{
    internal interface ITumblrService
    {
        Task FetchAndDisplayBlogData(string blogName, int start, int num);
    }
}
