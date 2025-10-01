using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            Console.WriteLine("Các phần tử sau khi Push: " + string.Join(", ", stack));

            int removed = stack.Pop();
            Console.WriteLine($"Phần tử bị Pop: {removed}");
            Console.WriteLine("Stack sau khi Pop: " + string.Join(", ", stack));

            int top = stack.Peek();
            Console.WriteLine($"Phần tử đầu (Peek): {top}");

            if (stack.Count == 0)
                Console.WriteLine("Stack đang rỗng.");
            else
                Console.WriteLine("Stack KHÔNG rỗng.");
        }
    }
}