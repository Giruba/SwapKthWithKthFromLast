using System;

namespace SwapKthFromStartAndLastInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap kth node from start with the kth node from last!");
            Console.WriteLine("-----------------------------------------------------");

            LinkedList linkedList = GetLinkedList();            
            linkedList.PrintLinkedList(linkedList.GetLinkedListHead());
            try
            {
                Console.WriteLine();
                Console.WriteLine("Enter 'K'");
                int k = int.Parse(Console.ReadLine());
                linkedList.SetLinkedListHead(linkedList.GetKthFromStartSwappedWithFromKthLast(
                    linkedList.GetLinkedListHead(), k));
                linkedList.PrintLinkedList(linkedList.GetLinkedListHead());
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static LinkedList GetLinkedList() {
            LinkedList linkedList = new LinkedList(null);

            Console.WriteLine("Enter the number of elements in the Linked List");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                LinkedListNode linkedListNode = null;
                for (int i = 0; i < noElements; i++) {
                   linkedListNode = linkedList.Append(linkedListNode, int.Parse(elements[i]));
                }
                linkedList.SetLinkedListHead(linkedListNode);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            return linkedList;
        }
    }
}
