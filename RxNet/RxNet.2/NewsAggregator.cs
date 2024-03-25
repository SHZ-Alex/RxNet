namespace RxNet.Spec;

public class NewsAggregator : IObservable<News>
{
    private readonly List<IObserver<News>> Observers = new(4);

    public IDisposable Subscribe(IObserver<News> observer)
    {
        Observers.Add(observer);

        return new UnSubscriber<News>(Observers, observer);
    }

    public void Notify(News news)
    {
        Observers.ForEach(x => x.OnNext(news));
    }
}