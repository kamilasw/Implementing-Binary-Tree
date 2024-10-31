using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLab05.Interfaces
{
    public interface IInventory<T>
    {
        
        public void AddItem(T item); //add an item to inventory
        public IEnumerable<T> GetItems(); //returns the ienum of all items in inventory
        public T FindItem(Func<T, bool> criteria);  //returns a single item based on criteria


    }
}
