using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("List Example:");
        
        List<string> list = new List<string>();

        // `Add`: Adds an object to the end of the List.
        list.Add("One");
        list.Add("Two");
        list.Add("Three");
        list.Add("Four");
        list.Add("Five");

        //Print the List
        Console.WriteLine("List contains below elements:");
       DisplayCollection(list);

        //`Remove`: Removes the first occurrence of a specific object from the List.
        list.Remove("Three");

        //Print the List
        Console.WriteLine("\nModified list after remove element 'Three' from list:");
        DisplayCollection(list);

        //Contains`: Determines whether the List contains a specific value.
        bool Ispresent = list.Contains("Five");
        Console.WriteLine("\nList contains Five:{0}",Ispresent);
        Ispresent = list.Contains("Three");
        Console.WriteLine("\nList contains Three:{0}\n", Ispresent);

        //`Sort`: Sorts the elements in the List.
        list.Sort();
        Console.WriteLine("After sorting the modified list:");
        DisplayCollection(list);

        //`Count`: Gets the number of elements contained in the List.
        Console.WriteLine("\nThe count of the list is {0}\n",list.Count);

        //`Clear`: Removes all elements from the List.
        list.Clear();
        Console.WriteLine("After clearing the list:");
        DisplayCollection(list);

        Console.WriteLine("Array Example:");
        int[] array = new int[5] { 5, 2, 1, 4,3 };
        DisplayCollection(array);
        Console.WriteLine("After sorting the array:");

        //Sort Array
        Array.Sort(array);
        DisplayCollection(array);

        //Contains
        Ispresent= array.Contains(5);
        Console.WriteLine("Checking if the array contains '5':{0}\n",Ispresent);

        //Count
        Console.WriteLine("Number of elements in the array:{0}\n",array.Length);

        //Dictionary Example:
        Console.WriteLine("Dictionary Example:");
        Dictionary<string,int> dictionary = new Dictionary<string,int>();
        dictionary.Add("One", 1);
        dictionary.Add("Two", 2);
        dictionary.Add("Three", 3);
        dictionary.Add("Four", 4);
        dictionary.Add("Five", 5);
        DisplayCollection(dictionary);

        //`Remove`: Removes the element with the specified key from the Dictionary.
        Console.WriteLine("\nAfter removing the key 'Two':");
        dictionary.Remove("Two");
        DisplayCollection(dictionary);

        //`ContainsKey`: Determines whether the Dictionary contains a specific key.
        Console.WriteLine("\nChecking if the dictionary contains key 'One':{0}",dictionary.ContainsKey("One"));
        Console.WriteLine("\nChecking if the dictionary contains value '3':{0}", dictionary.ContainsValue(3));
                           
        //`Count`: Gets the number of key/value pairs contained in the Dictionary.
        Console.WriteLine("\nNumber of key/value pairs in the dictionary: {0}",dictionary.Count());

        //`Keys`: Gets a collection containing the keys in the Dictionary.
        Console.WriteLine("\nKeys in the dictionary:");
        DisplayCollection(dictionary.Keys);
        Console.WriteLine("\nValues in the dictionary:");
        DisplayCollection(dictionary.Values);

        //LinkedList Example:
        LinkedList<int> linkedlist = new LinkedList<int>();
        Console.WriteLine("\nLinkedList Example:");
      
        //`AddLast`: Adds an element to the end of the LinkedList.
        linkedlist.AddLast(2);
        linkedlist.AddLast(3);
        linkedlist.AddLast(4);
        linkedlist.AddLast(5);
        DisplayCollection(linkedlist);

        //`AddFirst`: Adds an element to the beginning of the LinkedList.
        Console.WriteLine("\nAdd element at the first");
        linkedlist.AddFirst(1);
        DisplayCollection(linkedlist);

        //`Remove`: Removes the first occurrence of a specific object from the LinkedList.
        Console.WriteLine("\nAfter removing element '5':");
        linkedlist.Remove(5);
        DisplayCollection(linkedlist);

        //`Contains`: Determines whether the LinkedList contains a specific value.
        Console.WriteLine("\nChecking if the linked list contains '4': {0}",linkedlist.Contains(4));
        Console.WriteLine("\nChecking if the linked list contains '45': {0}", linkedlist.Contains(45));

        //`Count`: Gets the number of elements contained in the LinkedList.
        Console.WriteLine("\nNumber of elements in the linked list:{0}",linkedlist.Count);
    }
    static void DisplayCollection<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}