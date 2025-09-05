using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

namespace demos.dsa.solutions.dotnet.Problems
{
    public class Node
    {
        public int Value { get; set; }
        public int Key { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }
    }
    class LRUCache
    {
        Node head;
        Node tail;
        Dictionary<int, Node> cacheWithData;
        readonly int capacity;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cacheWithData = new Dictionary<int, Node>();
        }

        public int Get(int key)
        {
            int value = -1;
            Node temp; 

            if(cacheWithData.TryGetValue(key,out temp))
            {
                value = temp.Value;

                MoveTo(temp);
            }

            return value;
        }

        private void MoveTo(Node node)
        {
            if(head == node)
            {
                return;
            }
            
            if(node == tail)
            {
                var tempTail = tail;
                tail.Previous.Next = null;
                tail = tail.Previous;
            }
            else
            {
                var previous = node.Previous;
                previous.Next = node.Next;
                node.Next.Previous = previous;
            }

            head.Previous = node;
            node.Previous = null;
            node.Next = head;
            head = node;
        }

        public void Put(int key,int value)
        {
            if (cacheWithData.ContainsKey(key))
            {
                Node node = cacheWithData[key];
                MoveTo(node);
                node.Value = value;
            }
            else
            {
                Node node = new Node() { Key = key,Value = value};
                if (head == null)
                {
                    tail = head = node;
                }
                else
                {
                    node.Next = head;
                    head.Previous = node;
                    head = node;
                }

                cacheWithData.Add(key, node);
                if(cacheWithData.Count > capacity)
                {
                    cacheWithData.Remove(tail.Key);
                    if(tail.Previous !=null)
                    tail.Previous.Next = null;
                    tail = tail.Previous;
                }
            }
        }
    }
}