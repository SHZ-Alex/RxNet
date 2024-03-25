using System.Reactive.Disposables;
using System.Reactive.Linq;

var observable = Observable.Create<string>(observer =>
{
    observer.OnNext("HW");
    observer.OnNext("HW2");
    observer.OnNext("HW3");
    observer.OnError(new Exception("Something wron"));
    //
    //observer.OnCompleted();
    
    return Disposable.Empty;
});

var subscription = observable.Subscribe(Console.WriteLine, exception =>
{
    Console.WriteLine(exception.Message);
}, () => Console.WriteLine("Завершено"));

observable.Subscribe(Console.WriteLine);

subscription.Dispose();

static IObservable<Int32> UseCreate()
{
    return Observable.Create<Int32>(observer =>
    {
        observer.OnNext(1);
        observer.OnNext(2);
        observer.OnCompleted();
        Thread.Sleep(1000);

        return Disposable.Create(() => Console.WriteLine("Вызван Dispose"));
    });
}