using LinkedList;

namespace Queue
{
    /// <summary>
    /// Queue Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QueueClass<T>
    {
        #region Field
        LinkedListClass<T> queue;
        #endregion

        #region Constructor
        public QueueClass()
        {
            queue = new LinkedListClass<T>();
        }
        #endregion

        /// <summary>
        /// Method to check if Queue is empty and returns true if empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (queue.count == 0)
                return true;
            return false;
        }

        /// <summary>
        /// Method to add item at the end of the queue
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        /// <summary>
        /// Method to remove item from the front and returns it
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            var firstItem = queue.head;
            queue.Remove(firstItem.Data);
            return firstItem.Data;
        }

        /// <summary>
        /// Method to return the mumber of items in the queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return queue.count;
        }

        /// <summary>
        /// Method to display the items in the queue
        /// </summary>
        public void PrintQueue()
        {
            queue.PrintList();
        }
    }
}
