namespace RxNet.Reactive;

public record Reader(string Name) : IObserver<int>
{
    public void OnCompleted()
    {
        throw new NotImplementedException();
    }

    public void OnError(Exception error)
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine($"{Name}: {error.Message}");
        
        Console.ResetColor();
    }

    public void OnNext(int value)
    {
        Console.WriteLine($"{Name}: {value}");
    }
}