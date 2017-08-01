using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node leftNode;
        public Node rightNode;

        public Node(int value)
        {
            this.value = value;
            leftNode = null;
            rightNode = null;
        }

        //public void AddNode(int value)
        //{
        //    if (value > this.value && rightNode == null)
        //    {
        //        rightNode = new Node(value);
        //    }
        //    else if (value > this.value && rightNode != null)
        //    {
        //        rightNode.AddNode(value);
        //    }
        //    else if (value < this.value && leftNode == null)
        //    {
        //        leftNode = new Node(value);
        //    }
        //    else if (value < this.value && leftNode != null)
        //    {
        //        leftNode.AddNode(value);
        //    }
        //}

        //public int? GetNodeValue(int value)
        //{
        //    if (value == this.value)
        //    {
        //        return this.value;
        //    }

        //    if (value != this.value && rightNode == null && leftNode == null)
        //    {
        //        return null;
        //    }

        //    if (value > this.value && rightNode != null)
        //    {
        //        return rightNode.GetNodeValue(value);
        //    }
        //    else if (value < this.value && leftNode != null)
        //    {
        //        return leftNode.GetNodeValue(value);
        //    }

        //    return null;
        //}
    }
}
