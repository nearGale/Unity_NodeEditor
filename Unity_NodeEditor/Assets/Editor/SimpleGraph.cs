using UnityEngine;
using XNode;

[CreateAssetMenu]
public class SimpleGraph : NodeGraph 
{
    /// <summary>
    /// 在节点编辑器中，右键菜单增加功能
    /// </summary>
    [ContextMenu("Do Something")]
    void DoSomething()
    {
        Debug.Log("Perform operation");
    }
}