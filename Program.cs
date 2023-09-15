using ConsoleApp1;

MyClass m1= new MyClass();

Console.WriteLine("Enter string: ");
var str = Console.ReadLine(); 

Func myDelegate = null;
myDelegate += m1.Space; 
myDelegate += m1.Reverse; 

Run run = new Run();
run.runFunc(myDelegate, str);