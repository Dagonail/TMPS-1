using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Behavioral
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
        List<T> GetAll();
        void AddItem(T item);
    }
    public interface IIterator<T>
    {
        T First();
        T Next();
        T CurrentItem();
        bool IsDone();
        void AddItem(T item);
    }
    public class ConcereteAggregate<T> : IAggregate<T>
    {
        private IIterator<T> iterator;
        public ConcereteAggregate()
        {
            (this as IAggregate<T>).CreateIterator();
        }
        IIterator<T> IAggregate<T>.CreateIterator()
        {
            if (iterator == null)
                iterator = new ConcreteIterator<T>(this);
            return iterator;
        }
        List<T> IAggregate<T>.GetAll()
        {
            List<T> list = new List<T>();
            list.Add(iterator.First());
            while (!iterator.IsDone())
            {
                list.Add(iterator.Next());
            }
            return list;
        }
        void IAggregate<T>.AddItem(T item)
        {
            iterator.AddItem(item);
        }
    }

    public class ConcreteIterator<T> : IIterator<T>
    {
        private IAggregate<T> aggregate;
        private List<T> collection = new List<T>();
        private int pointer = 0;

        public ConcreteIterator(IAggregate<T> i)
        {
            aggregate = i;
        }
        T IIterator<T>.First()
        {
            pointer = 0;
            return collection[pointer];
        }
        T IIterator<T>.Next()
        {
            pointer++;
            return collection[pointer];
        }
        T IIterator<T>.CurrentItem()
        {
            return collection[pointer];
        }
        bool IIterator<T>.IsDone()
        {
            return pointer == collection.Count - 1;
        
        }
        void IIterator<T>.AddItem(T item)
        {
            collection.Add(item);
        }
    }
}
