using DevsTutorialCenterMVC.Models.Api;
using DevsTutorialCenterMVC.Models.Components;

namespace DevsTutorialCenterMVC.Models;

public class RejectedArticlesVM
{
    public IEnumerable<StoryArticlesVM> RejectedArticles { get; set; } = Enumerable.Empty<StoryArticlesVM>();
    public IEnumerable<TagViewModel> AllTags { get; set; } = Enumerable.Empty<TagViewModel>();
    public IEnumerable<AuthorListItemViewModel> TopAuthors { get; set; } = Enumerable.Empty<AuthorListItemViewModel>();
    public IEnumerable<BlogPostVM> RecentBlogPosts { get; set; } = new List<BlogPostVM>();
}