using System;
using System.Collections.Generic;

namespace GenericApplication {

   public class MyGenericArray<T> {
      private T[] array;
      
      public MyGenericArray(int size) {
         array = new T[size + 1];
      }
      
       public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), array[i]);
            }
        }
      int top =-1;

      public bool isEmpty()
        {
            if (top == -1) return true;
 
            return false;
        }

        public void Push(T value)
        {
            if (top == 10)
            {
                Console.WriteLine("Stack is full!");
            }
 
            else
            {
 
                array[++top] = value;
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
 
                return array[top--];
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
                return array[top];
            }
        }
   }
   
   class Tester {
      static void Main(string[] args) {
         
         //declaring an int array
         MyGenericArray<int> intArray = new MyGenericArray<int>(5);
         MyGenericArray<String> charArray = new MyGenericArray<String>(5);

         
                Console.Clear();
                Console.WriteLine("1. Integer.");
                Console.WriteLine("2. String.");
                Console.Write("Select your choice: ");
                int choicer = Convert.ToInt16(Console.ReadLine());

         while (true)
            {

                Console.WriteLine("\n\t****MENU****");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element.");
                Console.WriteLine("3. Remove top element.");
                Console.WriteLine("4. Display stack elements.");
                Console.WriteLine("5. Exit\n");
                Console.Write("Select your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an Element : ");
                        if(choicer==1){
                         intArray.Push(Convert.ToInt16(Console.ReadLine()));
                        }
                        else if(choicer==2){
                            charArray.Push(Console.ReadLine());                            
                        }
                        break;
 
                    case 2:

                    if(choicer==1){
                         Console.WriteLine("Top element is: {0}",intArray.Peek());
                        }
                        else if(choicer==2){
                            Console.WriteLine("Top element is: {0}",charArray.Peek());                  
                        }
                        break;
 
                    case 3: if(choicer==1){
                         Console.WriteLine("Element removed: {0}", intArray.Pop());
                        }
                        else if(choicer==2){
                            Console.WriteLine("Element removed: {0}", charArray.Pop());             
                        }
                        break;
 
                    case 4: if(choicer==1){
                         intArray.Display();
                        }
                        else if(choicer==2){
                            charArray.Display();            
                        }
                        break;
 
                    case 5: System.Environment.Exit(1);
                        break;
                }
                Console.ReadKey();
            }
      }
   }
}