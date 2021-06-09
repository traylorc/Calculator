using System;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
           foreach(var arg in args)
            {
                switch(arg.Substring(0,1))
                {
                    case "+":
                        {
                            var op1 = stack.Pop();
                            var op2 = stack.Pop();
                            var ans = op1 + op2;
                            stack.Push(ans);
                            break;
                        }
                    case "-":
                        {
                            var op1 = stack.Pop();
                            var op2 = stack.Pop();
                            var ans = op1 - op2;
                            stack.Push(ans);
                            break;
                        }
                    case "*":
                        {
                            var op1 = stack.Pop();
                            var op2 = stack.Pop();
                            var ans = op1 * op2;
                            stack.Push(ans);
                            break;
                        }
                    case "/":
                        {
                            var op1 = stack.Pop();
                            var op2 = stack.Pop();
                            var ans = op1 / op2;
                            stack.Push(ans);
                            break;
                        }
                        //process the operator
                        break;
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                        //convert to integer
                        int i;
                      var converted = int.TryParse(arg, out i);
                        if (!converted) continue;
                        stack.Push(i);
                        break;
                    default:
                        //throw it away
                        break;
                }
            }
            var ans1 = stack.Pop();
            Console.WriteLine($"{ans1}");
        }
    }
}
