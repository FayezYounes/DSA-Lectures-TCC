using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty
            Node temp = new Node(val);
            if (First == null)
            {
                temp.Next = First;
                First = temp;
                return;
            }
            Node move = First;
            while (move.Next !=null)
            {
                move = move.Next;
            }
            move.Next = temp;
            // create a new node with the given data
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
            if (First == null)
            {
                Console.WriteLine("the list is empty");
            }
            else
            {
                Node move = First;
                Node FirstIndicator = First;
                while (move != null)
                {
                    if (move.Data == key)
                    {
                        FirstIndicator.Next = move.Next;
                        move.Next = null;
                        return;
                    }
                    FirstIndicator = move;
                    move = move.Next;
                }
            }
            Console.WriteLine("the key does not exist");
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
            Node move = First;
            while (move.Next != null)
            {
                move=move.Next;
            }
            move.Next= other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
            Node prev, curr, next;
            curr = First;
            next = null;
            prev = null;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            First = prev;
        }
    }
}
