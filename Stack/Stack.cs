using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace StackWithFor
{
    public class Stack
    {
        private readonly List<object> _mylist = new List<object>();

        // Add an item on the list

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Invalid Object");
            
             _mylist.Add(obj);
        }

        // Remove an item from the list

        public object Pop()
        {
            if (_mylist.Count == 0)
                throw new InvalidOperationException("Empty List");

            var returnedValue = _mylist.Count - 1;
            _mylist.RemoveAt(_mylist.Count -1);

            return returnedValue;
        }

        //To clear the list //

        public void Clear()
        {
            _mylist.Clear();
            
        }

    }
}