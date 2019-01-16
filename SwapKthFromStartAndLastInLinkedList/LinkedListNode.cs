using System;
using System.Collections.Generic;
using System.Text;

namespace SwapKthFromStartAndLastInLinkedList
{
    class LinkedListNode
    {
        int data;
        LinkedListNode nextNode;

        public LinkedListNode(int data) {
            this.data = data;
        }

        public int GetData() {
            return data;
        }

        public LinkedListNode GetNextNode() {
            return nextNode;
        }

        public void SetData(int data) {
            this.data = data;
        }

        public void SetNextNode(LinkedListNode node) {
            this.nextNode = node;
        }
    }
}
