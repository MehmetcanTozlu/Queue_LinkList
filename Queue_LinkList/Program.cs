using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            List liste = new List();
            liste.Olustur();
            Console.ReadLine();
        }
    }
    class Node
    {
        public int data;
        public Node next;
    }
    class List
    {
        Node root = null;
        Node tail = null;
        public void Olustur()
        {
            for(int i = 0; i < 20; i++)
            {
                Enqueue(i * 10);
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Dequeue : "+dequeue());
            }
            for (int i = 0; i < 20; i++)
            {
                Enqueue(i * 10);
            }
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Dequeue : " + dequeue());
            }
            
        }
        public void Enqueue(int x)
        {
            if(root == null)
            {
                root = new Node();
                root.data = x;
                root.next = null;
                tail = root;
            }
            else
            {
                tail.next = new Node();
                tail.data = x;
                tail = tail.next;
                tail.next = null;
            }
        }
        public int dequeue()
        {
            if(root == null)
            {
                Console.WriteLine("Queue Bos!");
                return -1;
            }
            int rvalue = root.data;
            Node temp = root;
            root = root.next;
            return rvalue;
        }
    }
}
