using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeSort
{
    class TreeNode
    {
        public TreeNode lchild;
        public int info;
        public TreeNode rchild;
        public TreeNode(int i)
        {
            info = i;
            lchild = null;
            rchild = null;
        }
    }
}