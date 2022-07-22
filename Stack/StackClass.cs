using LinkedList;

namespace Stack
{
    /// <summary>
    /// Stack Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackClass<T>
    {
        #region Field
        LinkedListClass<T> stackValues;
        #endregion

        #region Constructor
        public StackClass()
        {
            stackValues = new LinkedListClass<T>();

        }
        #endregion

        /// <summary>
        /// Method to check if Stack is empty and returns true if empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (stackValues.count == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method to Add item at the top of the stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            stackValues.Add(item);
        }

        /// <summary>
        /// Method to remove the item at the top and returns the item
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            var top = stackValues.tail;
            stackValues.RemoveLast();
            return top.Data;
        }

        /// <summary>
        /// Method to return the value of the top element on the stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return stackValues.tail.Data;
        }

        /// <summary>
        /// Method to return the number of items in the stack
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return stackValues.count;
        }

        /// <summary>
        /// Method to display the items in the stack
        /// </summary>
        public void Print()
        {
            stackValues.PrintList();
        }
    }
}
