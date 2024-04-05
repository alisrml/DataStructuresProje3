using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class TreeNode
    {
        public UM_ALANI data;
        public TreeNode leftChild = null;
        public TreeNode rightChild = null;
        public void displayNode()
        {
            Console.WriteLine(" " + data.alanAdi + " ");
        }
        public void displayAllInfos()
        {
            Console.WriteLine(" " + data.ToString() + " ");
        }
    }
}
