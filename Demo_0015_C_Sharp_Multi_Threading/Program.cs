using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;

namespace Demo_0015_C_Sharp_Multi_Threading
{
    class Node
    {
        public void NodeTest1()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine($"Node Test 1: {i}");
            }
        }
        public void NodeTest2(object data)
        {
            Console.WriteLine($"Node Test 2: {data}");
        }
    }
    class Program
    {
        static void Test1()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine($"Test 1: {i}");
            }
        }
        static void Test2()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine($"Test 2: {i}");
                if(i == 50)
                {
                    Console.WriteLine("Thread 2 is going to sleep");
                    Thread.Sleep(1500);
                    Console.WriteLine("Thread 2 woke up");
                }
            }
        }
        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Test 3: {i}");
            }
        }
        static void Test4()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Test 4: {i}");
                if (i == 50)
                {
                    Console.WriteLine("Thread 4 is going to sleep");
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread 4 woke up");
                }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            Thread t4 = new Thread(Test4);

            Node n1 = new Node();
            Thread t5 = new Thread(n1.NodeTest1);
            Thread t6 = new Thread(n1.NodeTest2);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start(45);
        }
    }
}
