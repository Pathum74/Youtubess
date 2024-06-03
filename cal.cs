using System;

class Calculator
{
    static void Main(string[] args)
    {
        double n1,n2,result;
        char sy;
        
        Console.WriteLine("Number 1 :");
        n1=Convert.ToDouble(Console.ReadLine());
        
         Console.WriteLine("Number 2 :");
         n2=Convert.ToDouble(Console.ReadLine());
        
         Console.WriteLine("Enter a symbol = +, -, *, /");
         sy=Convert.ToChar(Console.ReadLine());
         
         switch (sy) 
         {
             case '+':
             result=n1 + n2;
             Console.WriteLine("Result is\b" + result);
             break;
             
             case '-':
             result=n1 - n2;
             Console.WriteLine("Result is\b" + result);
             break;
             
             case '*':
             result=n1 * n2;
             Console.WriteLine("Result is\b" + result);
             break;
             
             case '/':
             
              if (n2 !=0)
              {
                 result=n1 / n2;
              Console.WriteLine("Result is\b" + result);
              }
              else {
                  Console.WriteLine("Can not Divide by zero");
              }
             break;
             default:
             Console.WriteLine("Invalid input");
             break;

         }
         Console.ReadLine();
    }
}
