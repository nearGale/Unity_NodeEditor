using static UnityEngine.GraphicsBuffer;
using static XNodeEditor.NodeEditor;
using UnityEditor;
using XNodeEditor;

/// <summary>
/// 节点个性化显示的【节点编辑器】
/// </summary>
[CustomNodeEditor(typeof(NodeAdd))]
public class NodeAddEditor : NodeEditor
{
    private NodeAdd simpleNode;

    public override void OnBodyGUI()
    {
        if (simpleNode == null) simpleNode = target as NodeAdd;

        // Update serialized object's representation
        serializedObject.Update();

        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("a"));
        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("b"));
        UnityEditor.EditorGUILayout.LabelField("The value is " + simpleNode.GetSum());
        NodeEditorGUILayout.PropertyField(serializedObject.FindProperty("sum"));

        // Apply property modifications
        serializedObject.ApplyModifiedProperties();
    }
}