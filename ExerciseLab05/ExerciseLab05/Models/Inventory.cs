using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExerciseLab05.Interfaces;


namespace ExerciseLab05.Models 
{
    public class Inventory<T> : IInventory<T>, IEnumerable<T> where T : IComparable<T>
    {
        private List<T> items;

        public Inventory() {
            items = new List<T>();
        }

        public void AddItem(T item)
        {
            items.Add(item);

        }

        public IEnumerable<T> GetItems()
        {
            return items;
        }

        public T FindItem(Func<T, bool> criteria)
        {
            foreach (var item in items) {

                if (criteria(item)) {

                    return item;
                }
            
            
            }
            return default;

        }


        public IEnumerator<T> GetEnumerator()
        {
            for(int i=0;i<items.Count; i++)
            {
                yield return items[i];
            }
           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
