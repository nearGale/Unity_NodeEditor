using static XNode.Node;
using XNode;
using UnityEngine;

//[NodeTint("#ffaaaa")]
[NodeTint(0.8f, 0.3f, 0.3f)] // 节点颜色
[NodeWidth(304)] // 节点宽度
public class NodeSimple : Node
{
    [Input] public float value;
    [Output] public float result;

    private void Reset()
    {
        // 由于节点都派生自 ScriptableObject，因此 Unity 会在节点创建后立即调用 Reset（）。
        // 这位于 Awake 和 OnEnable 之前。如果要为节点设置自定义名称，建议您在此处进行。
        name = "MyName";
    }

    /// <summary>
    /// 获取output节点的值
    /// </summary>
    /// <param name="port">output节点</param>
    /// <returns>结果值</returns>
    public override object GetValue(NodePort port)
    {
        // Check which output is being requested. 
        // In this node, there aren't any other outputs than "result".
        if (port.fieldName == "result")
        {
            // Return input value + 1
            return GetInputValue<float>("value", this.value) + 1;
        }
        // Hopefully this won't ever happen, but we need to return something
        // in the odd case that the port isn't "result"
        else return null;
    }

    /// <summary>
    /// 右键菜单增加功能
    /// </summary>
    [ContextMenu("Do Something")]
    public void DoSomething()
    {
        // 节点支持“[ContextMenu]”属性。
        // 只需将“[ContextMenu]”添加到非静态方法中，当您右键单击节点标题时，它就会显示出来。选择它以执行该方法。
        Debug.Log($"NodeSimple do...");
    }
}