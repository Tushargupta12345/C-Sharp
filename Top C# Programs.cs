//[1. Array]
using System;

class ArrayExample
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
//[2. List]

using System;
using System.Collections.Generic;

class ListExample
{
    static void Main()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
        fruits.Add("Mango");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
//[3. LinkedList]

using System;
using System.Collections.Generic;

class LinkedListExample
{
    static void Main()
    {
        LinkedList<int> numbers = new LinkedList<int>();
        numbers.AddLast(10);
        numbers.AddLast(20);
        numbers.AddLast(30);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
//[4. Dictionary]

using System;
using System.Collections.Generic;

class DictionaryExample
{
    static void Main()
    {
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["John"] = 25;
        ages["Anna"] = 30;
        ages["Tom"] = 35;

        foreach (var pair in ages)
        {
            Console.WriteLine($"{pair.Key} is {pair.Value} years old.");
        }
    }
}
//[5. Stack]

using System;
using System.Collections.Generic;

class StackExample
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
//[6. Queue]

using System;
using System.Collections.Generic;

class QueueExample
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Customer1");
        queue.Enqueue("Customer2");
        queue.Enqueue("Customer3");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
//[7. HashSet]

using System;
using System.Collections.Generic;

class HashSetExample
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        set.Add("Apple");
        set.Add("Banana");
        set.Add("Orange");

        foreach (string fruit in set)
        {
            Console.WriteLine(fruit);
        }
    }
}
//[8. SortedList]

using System;
using System.Collections.Generic;

class SortedListExample
{
    static void Main()
    {
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");

        foreach (var pair in sortedList)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
//[9. SortedDictionary]

using System;
using System.Collections.Generic;

class SortedDictionaryExample
{
    static void Main()
    {
        SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
        dict[3] = "Three";
        dict[1] = "One";
        dict[2] = "Two";

        foreach (var pair in dict)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
//[10. BitArray]

using System;
using System.Collections;

class BitArrayExample
{
    static void Main()
    {
        BitArray bitArray = new BitArray(5);
        bitArray[0] = true;
        bitArray[1] = false;
        bitArray[2] = true;
        bitArray[3] = true;
        bitArray[4] = false;

        foreach (bool bit in bitArray)
        {
            Console.WriteLine(bit);
        }
    }
}
These examples demonstrate a variety of data structures in C#, 
including arrays, lists, linked lists, dictionaries, stacks, queues, hash sets, and more. 
Each structure is used in a context where its strengths can be showcased.
