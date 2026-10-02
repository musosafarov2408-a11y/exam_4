public class MyQueue<T>
{
    private List<T> _list = new List<T>();

    public void Enqueue(T item)
    {
        _list.Add(item);
    }

    public void Dequeue()
    {
        _list.RemoveAt(0);
    }

    public T Peek()
    {
        return _list[0];
    }

    public int Count()
    {
        return _list.Count();
    }

    public void Clear()
    {
        _list.Clear();
    }
}