using LinkedList;
using Stack;
using Queue;
#region Welcome Message
Console.WriteLine("==================================================================================================================");
Console.WriteLine("----------------------------------------Welcome to my Generic class test app--------------------------------------");
Console.WriteLine("==================================================================================================================");
#endregion

#region Linked List Test
Console.WriteLine("-----------------------------------------------------Linked List Test---------------------------------------------");
Console.WriteLine();
Console.WriteLine();
LinkedListClass<int> list = new LinkedListClass<int>();
list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
Console.WriteLine("List of elements in the Linked List");
list.PrintList();
Console.WriteLine();

Console.WriteLine("List of elements after last item is removed");
list.RemoveLast();
list.PrintList();
Console.WriteLine();

Console.WriteLine("List when an element is removed");
list.Remove(1);
list.PrintList();
Console.WriteLine();

Console.WriteLine("Validity of checked item in the Linked List");
Console.WriteLine(list.Check(2));
Console.WriteLine();

Console.WriteLine("The index of an item in the Linked List");
Console.WriteLine(list.Index(2));
Console.WriteLine("==================================================================================================================");

#endregion

#region Stack Test
Console.WriteLine("-----------------------------------------------------Stack Test---------------------------------------------------");
Console.WriteLine();
StackClass<int> stack = new StackClass<int>();
stack.Push(0);
stack.Push(1);
stack.Push(2);
Console.WriteLine("List of elements in the stack");
stack.Print();
Console.WriteLine();

Console.WriteLine("Check if Stack is empty");
Console.WriteLine(stack.IsEmpty());
Console.WriteLine();

Console.WriteLine("Last item in the stack removed");
Console.WriteLine(stack.Pop());
Console.WriteLine();

Console.WriteLine("Last element checked in the stack");
Console.WriteLine(stack.Peek());
Console.WriteLine();

Console.WriteLine("Size of the stack");
Console.WriteLine(stack.Size());
Console.WriteLine();
Console.WriteLine("==================================================================================================================");
#endregion

#region Queue Test
Console.WriteLine("-----------------------------------------------------Queue Test---------------------------------------------------");
Console.WriteLine();
QueueClass<int> queue = new QueueClass<int>();
queue.Enqueue(0);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
Console.WriteLine("List of elements in the Queue:");
queue.PrintQueue();
Console.WriteLine();

Console.WriteLine("Check if the queue is empty");
Console.WriteLine(queue.IsEmpty());
Console.WriteLine();

Console.WriteLine("Item removed at the front is:");
Console.WriteLine(queue.Dequeue());
Console.WriteLine();

Console.WriteLine("Size of the queue is:");
Console.WriteLine(queue.Size());
Console.WriteLine("-----------------------------------------------------Thank you----------------------------------------------------");
Console.WriteLine("==================================================================================================================");
#endregion
Console.Read();