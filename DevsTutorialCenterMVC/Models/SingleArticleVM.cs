﻿using DevsTutorialCenterMVC.Models.Components;

namespace DevsTutorialCenterMVC.Models;

public class SingleArticleVM
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public string AuthorId { get; set; }
    public string TagId { get; set; }
    public string TagName { get; set; }
    public int ReadCount { get; set; }
    public string? ImageUrl { get; set; }
    public string? PublicId { get; set; }
    public string ReadTime { get; set; }
    public int LikeCount { get; set; }
    public IEnumerable<CommentListItemVM> Comments { get; set; }
    public bool? Liked { get; set; }
    public bool? Bookmarked { get; set; }
    public DateTime CreatedOn { get; set; } 
}