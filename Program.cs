using System;

namespace dice
{
  class Program
  {
    static void Main(string[] args)
    {
      stateic void Main(string[] args)
      {
        dice d6 = dice(6);
        bool running = true;
        while (running)
        {
          Console.WriteLine("Press any Key to Roll")
                    Console.ReadKey();
          int total = 0;
          for (int i = 0; i < 3; i++)
          {
            int first = d6.Roll();
            int second = d6.Roll();
            Console.WriteLine(first + " : " second);
            if (first == second)
            {
              Console.WriteLine("BUST");
              total = 0;
              break;
            }
            total += first + second
                    }
          Console.WriteLine($"Your Score is: {total}");

        }
      }
      // Console.WriteLine("Hello World!");
      // int num = random.Next();  
      // int RandomNumber(int min, int max) 
    }
  }
}
