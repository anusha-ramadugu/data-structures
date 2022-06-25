// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

var n = 100;
var stack = new Stack.Stack<int>();
var stopWatch = new Stopwatch();
stopWatch.Start();
 for (int i = 0; i < n; i++)
{
   stack.Push(i);
   //stack.Push(100);
}
stopWatch.Stop();
Console.WriteLine($"ELASPED tricks -- {stopWatch.ElapsedTicks} and time span -- {stopWatch.Elapsed}");

Console.WriteLine($"stake length {stack.Count}");
static ArrayList GenerateNames()
{
   
   
   ArrayList names = new ArrayList();
   names.Add("anusha");
   names.Add("ramadugu");
   names.Add(1);
   names.Add(0.23);
   names.Add(new
   {
      Name = "an"
   });
   return names;
}

static void PrintNames(ArrayList names)
{
   foreach (string name in names)
   {
      Console.WriteLine($"NAME ; {name}");
   }
}