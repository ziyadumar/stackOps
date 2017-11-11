using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirstConsApp
{
    class Program
    {
        static void Main(string[] args)
        {         
            stack stac = new stack();
          while (true)
            {
                Console.Clear();
                Console.WriteLine("\n\t*******MENU*******\n");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Element : ");
                        stac.Push(Console.ReadLine());
                        break;
 
                    case 2: Console.WriteLine("Topmost element is: {0}", stac.Peek());
                        break;
 
                    case 3: Console.WriteLine("The element removed is: {0}", stac.Pop());
                        break;
 
                    case 4: stac.Show();
                        break;
 
                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
        }
    }
 
    interface Functions
    {
        Boolean isEmpty();
        void Push(Object element);
        Object Pop();
        Object Peek();
        void Show();
    }
    class stack : Functions
    {
        private int StackSize;
        public int FixSize
        {
            get 
                { return StackSize; }
            set 
                { StackSize = value; }
        }
        public int top;
        Object[] stacc;
        public stack()
        {
            FixSize = 10;
            stacc = new Object[FixSize];
            top = -1;
        }
        public stack(int capacity)
        {
            FixSize = capacity;
            stacc = new Object[FixSize];
            top = -1;
        }
        public bool isEmpty()
        {
            if (top == -1) return true;
 
            return false;
        }
        public void Push(object element)
        {
            if (top == (StackSize - 1))
            {
                Console.WriteLine("Stack is full!");
            }
 
            else
            {
 
                stacc[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }
        public object Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
 
                return stacc[top--];
            }
        }
        public object Peek()
        {
            if (isEmpty())
            {
 
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return stacc[top];
            }
        }
 
 
        public void Show()
        {
            for (int i = top; i > -1; i--)
            {
 
                Console.WriteLine("Item {0}: {1}", (i + 1), stacc[i]);
            }
        }
    }
}
