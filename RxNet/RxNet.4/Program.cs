using System.Reactive.Subjects;

var numberSub = new Subject<int>();

numberSub.Subscribe((value) =>
{
    Console.WriteLine(value);
},
exception =>
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine($"{exception.Message}");
        
    Console.ResetColor();
},
() 
    => Console.WriteLine("Завершено"));

// Кеширует прошлые OnNext, в конструкторе передаем значения
var replaySub = new ReplaySubject<int>(2);
var replaySub2 = new ReplaySubject<int>(TimeSpan.FromSeconds(2));

// кеширует только одну последнюю запись
var behSub = new BehaviorSubject<int>(10);

// хранит в кеше только одно значение, а опубликованно будет после вызова OnComplited
var asyncSub = new AsyncSubject<int>();

replaySub.OnNext(1);
replaySub.OnNext(2);
replaySub.OnNext(3);
replaySub.Subscribe(Console.WriteLine);
replaySub.OnNext(4);