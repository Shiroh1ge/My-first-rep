using System;


namespace asdf
{
    class Program
    {
        static void Main()
        {
           int x = 30;
           int y = 20;
          
           if (x < y)
           { Console.WriteLine("x is less than y"); 
           }
           else if (x > y)
           { 
               Console.WriteLine("x is greater than y"); 
           }
            else
           {
               Console.WriteLine("x is equal to y");
           }  
          
            Console.WriteLine("{0} + {1} = {2}", x, y, (x + y));
           
        }
    }
}
