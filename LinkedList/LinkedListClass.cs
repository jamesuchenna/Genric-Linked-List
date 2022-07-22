namespace LinkedList
{
    /// <summary>
    /// Linked List class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListClass<T>
    {
        /// <summary>
        /// Node Class
        /// </summary>
        public class ListNode
        {
            #region Node Field
            public T Data;
            #endregion

            #region Property
            public ListNode Next { get; set; }
            #endregion

            #region Constructor
            public ListNode(T data)
            {
                Data = data;
                Next = null;
            }
            #endregion
        }
        #region Linked List fields
        public ListNode head;
        public ListNode tail;
        public int count;
        #endregion

        /// <summary>
        /// Method to add a node to the tail and returns the count
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int Add(T obj)
        {
            if (head == null)
            {
                var newNode = new ListNode(obj);
                head = newNode;
                tail = newNode;
                count++;
            }
            else
            {
                var newNode = new ListNode(obj);
                tail.Next = newNode;
                tail = newNode;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Method to remove the first occurrence of a node and returns true if removed
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Remove(T obj)
        {
            if (head != null)
            {
                var currentNode = head;
                ListNode prevNode = null;
                while (currentNode != null)
                {
                    if (object.Equals(currentNode.Data, obj))
                    {
                        if (prevNode == null)
                        {
                            head = null;
                            head = currentNode.Next;
                            count--;
                            return true;
                        }
                        else
                        {
                            prevNode.Next = currentNode.Next;
                            count--;
                            return true;
                        }

                    }
                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }
            return false;
        }

        /// <summary>
        /// Method to remove last node in the Linked List
        /// </summary>
        public void RemoveLast()
        {
            if (count > 0)
            {
                if (count == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    ListNode currentNode = head;
                    while (currentNode.Next != tail)
                    {
                        currentNode = currentNode.Next;
                    }
                    tail = currentNode;
                    tail.Next = null;
                }
                count--;
            }
        }

        /// <summary>
        /// Method to check the occurrence of node in the List link and returns true if found
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Check(T item)
        {
            if (head != null)
            {
                var currentNode = head;
                while (currentNode != null)
                {
                    if (currentNode.Data.Equals(item))
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
            }
            return false;
        }

        /// <summary>
        /// Method to return the index of the occurrence of a node
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int Index(T item)
        {
            if (head != null)
            {
                var currentNode = head;
                var currentIndex = 0;
                while (currentNode != null)
                {
                    if (object.Equals(currentNode.Data, item))
                    {
                        return currentIndex;
                    }
                    currentNode = currentNode.Next;
                    currentIndex++;
                }
            }
            return -1;
        }

        /// <summary>
        /// Method to display the link list
        /// </summary>
        public void PrintList()
        {
            ListNode result = head;
            while (result != null)
            {
                Console.WriteLine(result.Data);
                result = result.Next;
            }
        }
    }
}