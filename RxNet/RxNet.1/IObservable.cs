namespace RxNet.Interface;

public interface IObservable<T>
{
    void Subscribe(Interface.IObserver<T> observer);
    void UnSubscribe(Interface.IObserver<T> observer);
    void Notify(T data);
}