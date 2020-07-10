using System;

namespace Stacks.Library
{
    public class MyStack
    {
        private object[] _items;
        private int _currentIndex;

        public MyStack(int capacity)
        {
            _items = new object[capacity];
            _currentIndex = -1;
        }

        public void Push(object item)
        {
            if (item == null) {
                throw new Exception("Cannot store nulls");
            }
            else
            {
                _currentIndex++;
                _items[_currentIndex] = item;
            }
        }

        public object Pop()
        {
            if (_currentIndex < 0) 
            {
                return null;
            }
            else 
            {
                object item = _items[_currentIndex];
                _currentIndex--;
                return item;
            }
        }
    }
}
