namespace RxNet.Spec;

public class News(string title, string content)
{
    public string Title { get; } = title;
    public string Content { get; } = content;
}