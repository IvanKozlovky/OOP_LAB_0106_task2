using System;
using System.Collections.Generic;

public class CollectionType<T>
{
    private List<T> _items;

    public CollectionType()
    {
        _items = new List<T>();
    }

    public CollectionType(IEnumerable<T> items)
    {
        _items = new List<T>(items);
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    public bool Remove(T item)
    {
        return _items.Remove(item);
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _items.Count)
                throw new IndexOutOfRangeException();

            return _items[index];
        }

        set
        {
            if (index < 0 || index >= _items.Count)
                throw new IndexOutOfRangeException();

            _items[index] = value;
        }
    }

    public int Count
    {
        get
        {
            return _items.Count;
        }
    }

    public IEnumerable<T> Items
    {
        get
        {
            return new List<T>(_items);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CollectionType<int> numbers = new CollectionType<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        Console.WriteLine($"Count of items in the collection: {numbers.Count}");
        Console.WriteLine("Items in the collection:");

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
