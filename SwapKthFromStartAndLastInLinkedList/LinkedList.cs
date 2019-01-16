using System;
using System.Collections.Generic;
using System.Text;

namespace SwapKthFromStartAndLastInLinkedList
{
    class LinkedList
    {
        LinkedListNode head;

        public LinkedList(LinkedListNode node) {
            head = node;
        }

        public void SetLinkedListHead(LinkedListNode linkedListNode) {
            head = linkedListNode;
        }

        public LinkedListNode GetLinkedListHead() {
            return head;
        }

        public LinkedListNode Append(LinkedListNode linkedListNode, int data) {
            if (linkedListNode == null) {
                linkedListNode = new LinkedListNode(data);
                return linkedListNode;
            }
            head = linkedListNode;
            while (linkedListNode != null && linkedListNode.GetNextNode() != null) {
                linkedListNode = linkedListNode.GetNextNode();
            }
            linkedListNode.SetNextNode(new LinkedListNode(data));
            return head;
        }

        public void PrintLinkedList(LinkedListNode linkedListNode) {
            if (linkedListNode == null) {
                Console.WriteLine("The given list is empty!");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("---Printing the linked list---");
            while (linkedListNode != null) {
                Console.Write(linkedListNode.GetData()+"->");
                linkedListNode = linkedListNode.GetNextNode();
            }
        }

        public LinkedListNode GetKthFromStartSwappedWithFromKthLast(LinkedListNode linkedListNode, int k) {
            int totalNodes = GetCount(linkedListNode);

            LinkedListNode kthStartNode = null;
            LinkedListNode kthEndNode = null;

            if (k <= totalNodes) {
                int count = 0;
                LinkedListNode current = linkedListNode;
                while (count < k-1) {
                    current = current.GetNextNode();
                    count++;
                }
                kthStartNode = new LinkedListNode(current.GetData());
                count = 0;
                current = linkedListNode;
                while (count < (totalNodes - k)) {
                    current = current.GetNextNode();
                    count++;
                }
                kthEndNode = new LinkedListNode(current.GetData());
                return SwapTwoNodes(linkedListNode, kthStartNode, kthEndNode);
            }
            Console.WriteLine("K cannot be greater than the number of nodes in the linked list");
            return null;            
        }

        private LinkedListNode SwapTwoNodes(LinkedListNode headNode,LinkedListNode kthStartNode, LinkedListNode kthEndNode) {
            if (headNode == null) {
                Console.WriteLine("Linkedlist is empty! can't swap any nodes!");
                return null;
            }
            LinkedListNode current = headNode;
            while (current != null) {
                if (current.GetData() == kthStartNode.GetData())
                {
                    current.SetData(kthEndNode.GetData());
                    current = current.GetNextNode();
                    while (current != null)
                    {
                        if (current.GetData() == kthEndNode.GetData())
                        {
                            current.SetData(kthStartNode.GetData());
                        }
                        else
                        {
                            current = current.GetNextNode();
                        }
                    }
                }
                else {
                    current = current.GetNextNode();
                }
            }
            return headNode;
        }


        private int GetCount(LinkedListNode linkedListNode) {
            if(linkedListNode == null){
                return 0;
            }

            int count = 0;
            while (linkedListNode != null) {
                linkedListNode = linkedListNode.GetNextNode();
                count++;
            }
            return count;
        }

    }
}
