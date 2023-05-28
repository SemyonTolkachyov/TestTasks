using System.Text;

namespace task1;

class HashTable
{
    public int Divider { get; }
    public ListNode<int>[] Values { get; set; }

    public HashTable(int divider)
    {
        Divider = divider;
        Values = new ListNode<int>[divider];
    }

    public void Insert(int newValue)
    {
        var hash = newValue % Divider;
        if (Values[hash] == null)
        {
            Values[hash] = new ListNode<int>();
        }
        Values[hash].Insert(newValue);
    }

    public override string ToString()
    {
        var output = new StringBuilder();

        for (var i = 0; i < Values.Length; i++)
        {
            output.Append(i);
            output.Append(':');

            var node = Values[i];
            while (node != null && node.Next != null)
            {
                output.Append(' ');
                output.Append(node.Next.Value);

                node = node.Next;
            }

            output.Append('\n');
        }

        return output.ToString();
    }
}