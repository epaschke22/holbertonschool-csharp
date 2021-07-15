﻿using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);
        if (aStack.Count != 0) {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        } else {
            Console.WriteLine("Stack is empty");
        }
        Console.WriteLine("Stack contains {0}: {0}", search, aStack.Contains(search));
        while (aStack.Contains(search)) {
            aStack.Pop();
        }
        aStack.Push(newItem);
        return aStack;
    }
}
