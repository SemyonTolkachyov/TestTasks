namespace task1;

public class ListNode<T>
{
    public ListNode() {}
    public ListNode(T value)
    {
        Value = value;
    }

    public T Value { get; set; }
    public ListNode<T> Next { get; private set; }

    public void Insert(T newValue)
    {
        var node = this;

        while (node.Next != null)
        {
            node = node.Next;
        }

        node.Next = new ListNode<T>(newValue);
    }
}