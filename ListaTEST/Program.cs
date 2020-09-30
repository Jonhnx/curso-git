using System;
using System.Collections.Generic;

namespace ListaTEST {
    class Program {
        static void Main(string[] args) {
            int i2 = 0;
            List<int> list = new List<int>();

            for(int i = 0; i <= 10; i++) {
                list.Insert(i ,i);
            }

            for(int i = -11; i < 0; i++) {
                list.Insert(i2,i);
                i2+=2;
            }
            foreach(int obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("______________________________________");

            list.Add(1);
            list.Add(2);
            list.Add(-3);
            list.Add(7);
            list.Add(10);
            list.Add(-6);
            list.Add(15);
            list.Insert(0, -20);

            /*list.RemoveAt(1);
            list.Remove(-3);
            list.RemoveAll(x => x > 10);
            list.RemoveRange(3, 2);*/

            List<int> positive = list.FindAll(x => x > 0);
            List<int> positive2 = list.FindAll(x => x < 0);

            

            foreach (int num in positive) {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------");
            foreach (int num in positive2) {
                Console.WriteLine(num);
            }
        }
    }
}
