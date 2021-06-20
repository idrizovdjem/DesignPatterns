using ObservablePattern.Observer;

namespace ObservablePattern.Observable
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);

        void Unsubscribe(IObserver observer);

        void Notify();
    }
}