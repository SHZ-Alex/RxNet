using System.Reactive.Subjects;
using RxNet.Reactive;

var numberSub = new Subject<int>();

var tokenSteve = numberSub.Subscribe(new Reader("Steve"));



numberSub.OnNext(1);
numberSub.Subscribe(new Reader("Nick"));

//отписывает Steve
tokenSteve.Dispose();

numberSub.OnNext(2);

// После этого OnNext работать не будет, после любой ошибки
numberSub.OnError(new Exception("something happens"));

// Завершается работа подписки и след отправка не сработает
numberSub.OnCompleted();

numberSub.OnNext(3);

if (numberSub.IsDisposed)
    Console.WriteLine("Dispose");