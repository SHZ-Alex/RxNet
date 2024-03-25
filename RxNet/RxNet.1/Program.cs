using RxNet;

const int timeAwait = 1000;

var newsAggregator = new NewsAggregator();

var steve = new Reader("Steve");
var nick = new Reader("Nick");

newsAggregator.Subscribe(steve);
newsAggregator.Subscribe(nick);

var news1 = new News("Alex in Moscow", "Today");
var news2 = new News("New kittens", "Last night");
var news3 = new News("New AI killer", "Again?");

newsAggregator.Notify(news1);
Task.Delay(timeAwait);
newsAggregator.Notify(news2);
Task.Delay(timeAwait);
newsAggregator.Notify(news3);
Task.Delay(timeAwait);

newsAggregator.UnSubscribe(steve);

newsAggregator.Notify(news1);
Task.Delay(timeAwait);
newsAggregator.Notify(news2);
Task.Delay(timeAwait);

