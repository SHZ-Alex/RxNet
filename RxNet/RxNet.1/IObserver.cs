namespace RxNet.Interface;

public interface IObserver<T>
{
    void Update(T news);
}