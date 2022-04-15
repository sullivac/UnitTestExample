using System;
using System.Collections.Generic;

namespace UnitTestExample
{
    public class ReversePolishCalculator
    {
        private readonly string[] terms;

        public ReversePolishCalculator(string[] terms)
        {
            this.terms = terms;
        }

        public double Calculate()
        {
            var stack = new Stack<double>();

            for (var i = 0; i < terms.Length; i++)
            {
                var term = terms[i];

                if (term == "+")
                {
                    Apply(stack, Add);
                }
                else if (term == "-")
                {
                    Apply(stack, Subtract);
                }
                else if (term == "*")
                {
                    Apply(stack, Multiply);
                }
                else if (term == "/")
                {
                    Apply(stack, Divide);
                }
                else
                {
                    stack.Push(double.Parse(term));
                }
            }

            return stack.Pop();
        }

        private static void Apply(Stack<double> stack, Func<double, double, double> operatorFunction)
        {
            stack.Push(operatorFunction(stack.Pop(), stack.Pop()));
        }

        private static double Add(double x, double y)
        {
            return x + y;
        }

        private static double Subtract(double x, double y)
        {
            return x - y;
        }

        private static double Multiply(double x, double y)
        {
            return x * y;
        }

        private static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}