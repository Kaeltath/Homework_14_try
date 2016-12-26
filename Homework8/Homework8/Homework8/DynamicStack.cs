﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class DynamicStack<T> : Buffer<T>, IMyStack<T>
    {
        private int MaxSize = 79;
        DynamicArray<T> Buffer = new DynamicArray<T>();

        public DynamicStack(int maxsize)
        {
            this.MaxSize = maxsize;
        }

        public void Push(T toPushValue)
        {

            if (Buffer.Size < MaxSize)
            {
               Buffer.Add(toPushValue);
            }
            else
            {
                Console.WriteLine("Buffer is Full");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public T Pop()
        {
            T temp;
            temp = Buffer.Get(Buffer.Size );
            Buffer.Remove(Buffer.Size );
            return temp;
        }

        public T Peek()
        {
            return Buffer.Get(Buffer.Size );
        }
    }
}
