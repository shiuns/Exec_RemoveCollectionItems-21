using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_RemoveCollectionItems____21謝孟勳
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>();
            items.Add(1);
            items.Add(3);
            items.Add(18);
            items.Add(35);
            items.Remove(18);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
