namespace RxNet.Spec;

public class Reader(string name) : IObserver<News>
{
    public string Name { get; set; } = name;

    public void OnCompleted()
    {
    }

    public void OnError(Exception error)
    {
        Console.WriteLine($"error {error.Message}");
    }

    public void OnNext(News value)
    {
        Console.WriteLine(Name);
        Console.WriteLine(value.Title);
        Console.WriteLine(value.Content);
        Console.WriteLine("----------------------------");
    }
}