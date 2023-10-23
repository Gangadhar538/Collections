using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class StackEx
    {
        public void DisplayK()
        {
            Stack stack = new Stack();

            stack.Push(1);

            stack.Push(2);

            stack.Push("Hello");

            stack.Push("Test");

            int c = stack.Count;

            Console.WriteLine($"Total count = {c}");
            Console.WriteLine($"The value on top of stack is {stack.Peek()}");



            while (c > 0)
            {
                Console.WriteLine(stack.Pop());
                c--;
            }
        }
    }
}