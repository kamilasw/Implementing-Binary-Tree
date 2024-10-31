using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExerciseLab05.Models
{
    internal class BinaryTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> root;

        public void Add(T value)
        {
            BinaryTreeNode<T> nod = root;
            BinaryTreeNode<T> x = new BinaryTreeNode<T>(value);
            if (nod == null)
            {
                root = x;
                return;

            }

            while(nod != null)
            {
                
                if (value.CompareTo(nod.Value) == 0)
                {
                    return;
                }
                if (value.CompareTo(nod.Value) > 0)
                {
                    if(nod.Right == null)
                    {
                        nod.Right = x;
                        return;
                    }

                    nod = nod.Right;
                }
                else if (value.CompareTo(nod.Value) < 0)
                {
                    if(nod.Left == null)
                    {
                        nod.Left = x;
                        return;
                    }
                    nod = nod.Left;
                }


            }

            return;
            
            

        }

        public T Find(Func<T, bool> predicate)
        {
            if (root == null) return default;
            if (predicate(root.Value)) return root.Value;

            var leftResult = Find(predicate);
            return leftResult ?? Find(predicate);


        }

        public IEnumerable<T> InOrderTraversal()
        {
            return InOrderTraversalRecursive(root);
        }

        private IEnumerable<T> InOrderTraversalRecursive(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                foreach (var item in InOrderTraversalRecursive(node.Left))
                    yield return item;

                yield return node.Value;

                foreach (var item in InOrderTraversalRecursive(node.Right))
                    yield return item;
            }
        }


    }
}
