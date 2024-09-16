using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Trees
{
    public  class Tree
    {
        private TreeNode root;

        public Tree()
        {
            root = new TreeNode
            {
                Children = new List<TreeNode>
            {
                new TreeNode
                {
                    Children = new List<TreeNode>
                    {
                        new TreeNode(),
                        new TreeNode()
                    }
                },
                new TreeNode()
                {
                    Children = new List<TreeNode>
                    {
                        new TreeNode()
                    }
                }
            }
            };

            IEnumerable<TreeNode> allNodes = TreeNode.GetAllNodes(root);
            Console.WriteLine($"{allNodes.Count()}");
        }
    }

    sealed class TreeNode
    {
        public IEnumerable<TreeNode> Children { get; init; }

        /*
           Bu metot, bir TreeNode nesnesini ve onun tüm alt düğümlerini sıralı şekilde döndürür.
           Bir yığın (stack) kullanılarak düğümler üzerinde iterasyon yapılır.
           Bu yöntem, derinlemesine arama (depth-first search - DFS) yaklaşımı kullanır.
           İlk olarak kök düğüm (root) yığına eklenir. Yığın boş olmadığı sürece döngü devam eder.
           Yığından bir düğüm çıkartılır (pop işlemi) ve yield return ifadesiyle döndürülür.
           Eğer mevcut düğümün alt düğümleri varsa, bu alt düğümler yığına eklenir.
           Reverse fonksiyonu, alt düğümleri sondan başa doğru dolaşmak için kullanılır (böylece en soldaki düğüm en önce işlenir).
         */
        public static IEnumerable<TreeNode> GetAllNodes(TreeNode node)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();

            stack.Push(node);

            while (stack.Count > 0)
            {
                TreeNode current = stack.Pop();

                yield return current;

                if (current.Children != null)
                {
                    foreach (TreeNode child in current.Children.Reverse())
                    {
                        stack.Push(child);
                    }

                }
            }
        }
    }


}
