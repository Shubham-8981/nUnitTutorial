using System;

namespace nunitDemo
{
    public class Calculator : IDisposable
    {
        public int add(int n1, int n2)
        {
            return n1 + n2;
        }

        public void Dispose()
        {
            
        }

        public int subtract(int n1, int n2)
        {
            if(n1<n2)
            {
                throw new ArgumentException("First number should be greater than second number");
            }
            else
            {
                return n1 - n2;
            }
        }
    }
}
