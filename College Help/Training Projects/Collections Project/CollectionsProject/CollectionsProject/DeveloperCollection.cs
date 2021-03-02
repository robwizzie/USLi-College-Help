// C# code to create a Collection 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class GFG
{

    // Driver code 
    public static void Main()
    {
        // Creating a collection of ints
        Collection<int> myColl = new Collection<int>();

        // Adding elements in Collection myColl 
        myColl.Add(1);
        myColl.Add(2);
        myColl.Add(3);
        myColl.Add(4);

        // Displaying the elements in myColl 
        foreach (int i in myColl)
        {
            Console.WriteLine(i);
        }
    }
}

