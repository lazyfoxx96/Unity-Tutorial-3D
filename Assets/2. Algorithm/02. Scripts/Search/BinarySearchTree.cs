using System.Xml;
using UnityEngine;

public class BinarySearchTree : MonoBehaviour
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int value;

        public TreeNode(int value)
        {
            this.value = value;
        }
    }

    private TreeNode root;
    private int[] array = { 8, 3, 10, 1, 6, 14, 4, 7, 13 }; //배열
    private string result;

    private void Start()
    {
        foreach(var v in array)
            root = InsertNode(root, v);

        PreOrder(root);
        Debug.Log($"PreOrder : {result.TrimEnd(',')}");

        result = string.Empty;
        InOrder(root);
        Debug.Log($"InOrder : {result.TrimEnd(',')}");

        result = string.Empty;
        PostOrder(root);
        Debug.Log($"PostOrder : {result.TrimEnd(',')}");
    }

    private TreeNode InsertNode(TreeNode node, int v)
    {
        if(node == null)
            return new TreeNode(v);

        if(v < node.value)
            node.left = InsertNode(node.left, v);
        else
            node.right = InsertNode(node.right, v);

        return node;
    }

    private void PreOrder(TreeNode node) // 전위 순회
    {
        if(node == null)
            return;

        result += $"{node.value}, ";
        PreOrder(node.left);
        PreOrder(node.right);
    }

    private void InOrder(TreeNode node) // 중위 순회
    {
        if (node == null)
            return;

        InOrder(node.left);
        result += $"{node.value}, ";
        InOrder(node.right);
    }

    private void PostOrder(TreeNode node) // 후위 순회
    {
        if (node == null)
            return;

        PostOrder(node.left);
        PostOrder(node.right);
        result += $"{node.value}, ";
    }
}
