namespace RxNet;

public class Reader(string name) : Interface.IObserver<News>
{
    public string Name { get; set; } = name;
    
    public void Update(News news)
    {
        Console.WriteLine(Name);
        Console.WriteLine(news.Title);
        Console.WriteLine(news.Content);
        Console.WriteLine("----------------------------");
    }
}