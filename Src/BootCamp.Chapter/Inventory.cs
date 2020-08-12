using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        public Item[] GetItems()
        {
            return _items;
        }

        public Inventory()
        {
            _items = new Item[0];
        }

        public Item[] GetItems(string name)
        {

            foreach (var item in _items)
            {
                if (name.Equals(item.GetName()))
                {
                    return new Item[1] {item};
                }
            }
            
            return new Item[0];
        }

        public void AddItem(Item item)
        {
            
            var newItems = new Item[_items.Length +1];

            for(int i =0; i < _items.Length; i++ )
            {
                newItems[i] = _items[i];
            }

            newItems[^1] = item;
            _items = newItems;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            var newItems = new List<Item>(); 

            for (int i = 0; i < _items.Length -1; i++)
            {
                if (!_items.Contains(item))
                {
                    return;
                }

                if (!item.GetName().Equals(_items[i].GetName()))
                {
                    newItems.Add(_items[i]);
                }
            }

            _items = newItems.ToArray();
        }
    }
}
