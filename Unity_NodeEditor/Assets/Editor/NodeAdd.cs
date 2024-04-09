using static XNode.Node;
using XNode;

public class NodeAdd : Node
{
    public int a;
    public int b;
    [Output] public int sum;

    public override object GetValue(NodePort port)
    {
        return GetSum();
    }

    public float GetSum()
    {
        return a + b;
    }
}