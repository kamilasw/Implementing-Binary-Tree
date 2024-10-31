using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLab05.Models
{
    internal class BinaryTreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

       
        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;

        }




    }
}
