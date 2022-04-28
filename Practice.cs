using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_Csharp_homework_3._0
{
    internal class Practice
    {

        static void Main(string[] args)
        {
            //NON-GENERIC

            ArrayList arrList = new ArrayList();
            arrList.Add("Dumitru");
            arrList.Add(20);
            foreach (var i in arrList)
            {
                Console.WriteLine(i);
            }

            Hashtable ht = new Hashtable();
            ht.Add("key", 20);
            ht.Add("key1", "Dumitru");
            ht.Add("key2", "Dumitru");
            ht.Add("key3", "Dumitru145");
            ht.Add("key4", "Dumitru676");

            ICollection keys = ht.Keys;

            foreach (var i in keys)
            {
                Console.WriteLine(ht[i]);
            }

            SortedList sortedList = new SortedList();
            sortedList.Add("key", "Dumitru");
            sortedList.Add("key1", "Rotaru");
            sortedList.Add("key2", 20);
            sortedList.Add("key3", 100);

            ICollection keys1 = sortedList.Keys;

            foreach (var i in keys1)
            {
                Console.WriteLine(sortedList[i]);
            }

            Stack stack = new Stack();
            stack.Push("yoyoy");
            stack.Push(14);
            stack.Push(15); 
            stack.Push("zozozo");

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            Queue queue = new Queue();
            queue.Enqueue(1213);
            queue.Enqueue("asfghj");
            queue.Enqueue(99595);
            queue.Enqueue("qwerty");

            foreach(var i in queue)
            {
                Console.WriteLine(i);
            }

            // ---------------------------------------------------------------------------
            // GENERIC
           

            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("key1", 250);
            keyValuePairs.Add("key2", 350);
            keyValuePairs.Add("key3", 450);
            keyValuePairs.Add("key4", 450);

            foreach(var i in keyValuePairs)
            {
                Console.WriteLine(i);
            }

            SortedList<string, string> keyValuePairs1= new SortedList<string, string>();
            keyValuePairs1.Add("key1", "qwerty1");
            keyValuePairs1.Add("key2", "qwerty2");
            keyValuePairs1.Add("key3", "qwerty3");
            keyValuePairs1.Add("key4", "qwerty3");

            ICollection <string> keysSortedList = keyValuePairs1.Keys;
            ICollection<string> valuesSortedList = keyValuePairs1.Values;
            
            foreach(var i in valuesSortedList)
            {
                Console.WriteLine(i);
            }

            Stack<int> stack1= new Stack<int>();
            stack1.Push(-100);
            stack1.Push(100);
            stack1.Push(105);

            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }

            Queue<string> q = new Queue<string>();
            q.Enqueue("zcxv");
            q.Enqueue("zcxv1");
            q.Enqueue("zcxv2");
            q.Enqueue("zcxv3");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }






        }
    }
}
