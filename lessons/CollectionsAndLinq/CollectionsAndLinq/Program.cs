using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Security.Cryptography;

namespace CollectionsAndLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            object obj = i;
            ++i;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.WriteLine((short)obj);
        }
    }
}
