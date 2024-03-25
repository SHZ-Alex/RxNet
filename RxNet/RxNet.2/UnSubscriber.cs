namespace RxNet.Spec;

public class UnSubscriber<T> : IDisposable
{
    private readonly List<IObserver<T>> Observers;
    private readonly IObserver<T> Observer;
    
    public UnSubscriber(List<IObserver<T>> observers, IObserver<T> observer)
    {
        Observers = observers;
        Observer = observer;
    }

    public void Dispose()
    {
        if (Observers.Contains(Observer))
        {
            Observers.Remove(Observer);
        }
    }
}