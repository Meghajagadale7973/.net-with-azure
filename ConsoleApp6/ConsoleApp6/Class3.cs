using System;
using System.Collections;
using System.Text;

namespace ConsoleApp6
{
    class Class3
    {
        public static void Main3(String[] args)
        {
            ArrayList a1 = new ArrayList();
            string str = "megha";
            int x = 5;
            DateTime d = DateTime.Now;
            a1.Add(str);
            a1.Add(x);
            a1.Add(d);
            a1.Remove(d);
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }



      
            Console.WriteLine("================");

            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.net");
            ht.Add("cs", "cs.net");
            ht.Add( "asp","asp.net");
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "====>" + item.Value);
            }


            //stack
            //LIFO
            Console.WriteLine("================");


            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }

            //queue
            //FIFO
            Console.WriteLine("================");

            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("================");
            //sortedlist
            //it is a class that has the combination of arraylist and hashtable
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }























        }














    }
}
