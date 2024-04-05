using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class MyBinarySearchTree
    {
        private TreeNode root;
        public UM_ALANI um_alani;
        

        public MyBinarySearchTree() {
            root = null;
        }

        public TreeNode getRoot()
        {
            return root;
        }

        public void setRoot(TreeNode root)
        {
            this.root = root;
        }

        public void preOrder(TreeNode localRoot)
        {
            if(localRoot != null)
            {
                localRoot.displayNode();
                preOrder(localRoot.leftChild);
                preOrder(localRoot.rightChild);
            }
        }

        public void inOrder(TreeNode localRoot)
        {
            if(localRoot != null)
            {
                inOrder(localRoot.leftChild);
                localRoot.displayNode();
                inOrder(localRoot.rightChild);
            }
        }

        public void postOrder(TreeNode localRoot)
        {
            if (localRoot != null)
            {
                postOrder(localRoot.leftChild);
                postOrder(localRoot.rightChild);
                localRoot.displayNode() ;
            }
        }

        public void insert(UM_ALANI newData)
        {
            TreeNode newNode = new TreeNode();
            newNode.data = newData;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                TreeNode current = root;
                TreeNode parent;

                while (true)
                {
                    parent = current;
                    int sonuc = newData.alanAdi.CompareTo(current.data.alanAdi);
                    if (sonuc < 0)//bu durudmda yeni alan alfabetik olarak daha önce geliyor.
                    {
                        current = current.leftChild;
                        if(current == null)
                        {
                            parent.leftChild = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if(current == null)
                        {
                            parent.rightChild = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void metot1b(TreeNode root)
        {
            Console.Write("Ağaç derinliği: "+FindTreeDepth(root)+"\nAğacın düğüm sayısı: "+CalculateNodes(root)+"\nDengeli olsaydı derinlik: "+balancedDepth(root)+"\n");
            printAllInfos(root);
        }

        private void printAllInfos(TreeNode localRoot)
        {
            if (localRoot != null)
            {
                printAllInfos(localRoot.leftChild);
                localRoot.displayAllInfos();
                printAllInfos(localRoot.rightChild);
            }
        }

        private int FindTreeDepth(TreeNode localRoot)
        {
            if(localRoot == null)
            {
                return 0;
            }
            else
            {
                int leftTreeDepth = FindTreeDepth(localRoot.leftChild);
                int rightTreeDepth = FindTreeDepth(localRoot.rightChild);

                return Math.Max(leftTreeDepth, rightTreeDepth)+1;
            }
        }

        private int CalculateNodes(TreeNode localroot)
        {
            if (localroot == null)
            {
                return 0;
            }
            else
            {
                return 1 + CalculateNodes(localroot.leftChild) + CalculateNodes(localroot.rightChild);
            }

        }
    
        private int balancedDepth(TreeNode localroot)
        {
            int balancedDepth = 0;
            int totalNodes = CalculateNodes(localroot);

            while(totalNodes > 0)
            {
                if(totalNodes >= Math.Pow(2, balancedDepth))
                {
                    totalNodes -= (int)Math.Pow(2, balancedDepth);
                    balancedDepth++;
                }
                else
                {
                    if (totalNodes > 0) { balancedDepth++; }
                    break;
                }
            }
            return balancedDepth;
        }

        public void metot1c(TreeNode root)
        {
            Console.Write("Baslnagıc harf değerini girin:");
            string girdi1 = Console.ReadLine();
            Console.Write("Bitis harf değerini girin:");
            string girdi2 = Console.ReadLine();
            girdi1 = girdi1.ToUpper();
            girdi2 = girdi2.ToUpper();

            char start = girdi1[0];
            char end = girdi2[0];

            //burada yapılan dönüşümün amacı türkçe alfabesine özel bulunan harflerin ASCII
            //kodlarının sıralı olmaması. Fakat türkçe alfebesine özel karakterler benzerleri ile
            //sıralı oldukları için aşağıdaki dönüşüm ile sorun çözülmüştür.
            if (start.Equals("İ")) { start = 'I'; }
            if (start.Equals("Ö")) { start = 'O'; }
            if (start.Equals("Ü")) { start = 'U'; }
            if (start.Equals("Ş")) { start = 'S'; }
            if (end.Equals("İ")) { end = 'I'; }
            if (end.Equals("Ö")) { end = 'O'; }
            if (end.Equals("Ü")) { end = 'U'; }
            if (end.Equals("Ş")) { end = 'S'; }

            metot1cHelper(root, start, end);
        }
        
        private void metot1cHelper(TreeNode localroot,char start,char end)
        {
            if(localroot != null)
            {
                metot1cHelper(localroot.leftChild,start,end);
                char currentChar = localroot.data.alanAdi[0];
                if (currentChar >= start && currentChar <= end)
                {
                    localroot.displayAllInfos();
                }
                metot1cHelper(localroot.rightChild,start,end);
            }
        }

        public MyBinarySearchTree metot1d(TreeNode localRoot)
        {
            MyBinarySearchTree balancedTree = new MyBinarySearchTree();
            List<UM_ALANI> sortedList = new List<UM_ALANI>();

            sortedList = sortingInOrder(localRoot, sortedList);
            TreeNode newRoot = new TreeNode();
            int start = 0;
            int end = sortedList.Count - 1;
            balancedTree.metot1dHelper(balancedTree,sortedList,start,end);

            return balancedTree;
        }

        private void metot1dHelper(MyBinarySearchTree tree,List<UM_ALANI> sortedList,int start,int end)
        {
            if(start <= end)
            {
                int mid = (start + end) / 2;
                tree.insert(sortedList[mid]);

                metot1dHelper(tree,sortedList,start,mid-1);
                metot1dHelper(tree, sortedList, mid + 1, end);
            }
            
        }

        private List<UM_ALANI> sortingInOrder(TreeNode localroot, List<UM_ALANI> sortedList)
        {
            if (localroot != null)
            {
                sortingInOrder(localroot.leftChild, sortedList);
                sortedList.Add(localroot.data);
                sortingInOrder(localroot.rightChild, sortedList);
            }
            return sortedList;
        }

        public Hashtable metot2a(List<UM_ALANI> alanlar)
        {
            Hashtable myhash = new Hashtable();
            foreach(UM_ALANI alan in alanlar)
            {
                myhash.Add(alan.alanAdi, alan);
            }
            return myhash;
        }

        public Hashtable metot2b(Hashtable myhash)
        {
            Console.WriteLine("Hastableda bulunan key değerleri:");
            foreach(string key in myhash.Keys)
            {
                Console.WriteLine(key);
            }

            Console.Write("Güncellenecek alanın adı: ");
            string oldName = Console.ReadLine();

            Console.Write("Alanın yeni adı: ");
            string newName = Console.ReadLine();    
            
            Object oldAlan = myhash[oldName];
            UM_ALANI tempAlan = (UM_ALANI)oldAlan;
            
            tempAlan.alanAdi = newName;
            
            myhash.Add(newName, tempAlan);
            myhash.Remove(oldName);

            Console.WriteLine("Hastableda bulunan key değerleri:");
            foreach (string key in myhash.Keys)
            {
                Console.WriteLine(key);
            }

            return myhash;
        }
    }
}
