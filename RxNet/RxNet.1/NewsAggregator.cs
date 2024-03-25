namespace RxNet;

public class NewsAggregator : Interface.IObservable<News>
{
    private readonly List<Interface.IObserver<News>> _observers = new(4);

    public void Subscribe(Interface.IObserver<News> observer)
    {
        _observers.Add(observer);
    }

    public void UnSubscribe(Interface.IObserver<News> observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(News data)
    {
        _observers.ForEach(x => x.Update(data));
    }
}