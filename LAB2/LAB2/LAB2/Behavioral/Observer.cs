using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Behavioral
{
    public interface ISubject<T>
    {
        List<IObserver<T>> Observers { get; }
        void Attach(IObserver<T> i);
        IObserver<T> Detach(IObserver<T> i);
        void Notify();
        T GetState();
        void SetState(T state);
    }

    public class ConcreteSubject<T> : ISubject<T>
    {
        private List<IObserver<T>> Observers = new List<IObserver<T>>();
        private T SubjectState;

        List<IObserver<T>> ISubject<T>.Observers
        {
            get { return Observers; }
        }

        void ISubject<T>.Attach(IObserver<T> i)
        {
            Observers.Add(i);
        }

        IObserver<T> ISubject<T>.Detach(IObserver<T> i)
        {
            Observers.Remove(i);
            return i;
        }

        void ISubject<T>.Notify()
        {
            foreach (IObserver<T> o in Observers)
                o.Update(SubjectState);  
        }

        T ISubject<T>.GetState()
        {
            return SubjectState;
        }

        void ISubject<T>.SetState(T state)
        {
            SubjectState = state;
            ((ISubject<T>)this).Notify();  
        }
    }

    public interface IObserver<T>
    {
        void Update(T subjectState);

    }

    public class ConcreteObserver<T> : IObserver<T>
    {
        private T observerState;
        private IMenu name;

        public ConcreteObserver(IMenu name)
        {
            this.name = name;
        }

        void IObserver<T>.Update(T subjectState)
        {
            observerState = subjectState;
            Console.WriteLine(this.name + " is now " + this.observerState);
        }

    }
}
