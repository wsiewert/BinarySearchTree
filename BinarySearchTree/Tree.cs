using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        Node rootNode;

        public Tree(int value)
        {
            rootNode = new Node(value);
        }

        public void Add(int value)
        {
            Add(rootNode, value);
        }

        public Node Add(Node node, int value)
        {
            if (value > node.value && node.rightNode == null)
            {
                Node childNode = new Node(value);
                node.rightNode = childNode;
                return childNode;
            }
            else if (value > node.value && node.rightNode != null)
            {
               return Add(node.rightNode, value);
            }
            else if (value < node.value && node.leftNode == null)
            {
                Node childNode = new Node(value);
                node.leftNode = childNode;
                return childNode;
            }
            else if (value < node.value && node.leftNode != null)
            {
                return Add(node.leftNode, value);
            }
            return node;
        }

        public bool Find(int value)
        {
            return Find(rootNode, value);
        }

        public bool Find(Node node, int value)
        {
            if (node.value == value)
            {
                return true;
            }

            if (node.value != value && node.leftNode == null && node.rightNode == null)
            {
                return false;
            }

            if (value > node.value && node.rightNode != null)
            {
                return Find(node.rightNode,value);
            }
            else if (value < node.value && node.leftNode != null)
            {
                return Find(node.leftNode, value);
            }

            return false;
        }
    }
}
