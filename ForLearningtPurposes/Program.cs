using SortedListInDescendingOrder;
using System;
using System.Collections.Generic;

public sealed class Program
{
    public static void Main()
    {
        SortedList<Intern, int> descSortedList = new SortedList<Intern, int>(new DescendingComparerByInternAge<Intern>());
        var john = new Intern { FirstName = "John", LastName = "John", Age = 20, HasExperience = false };
        var mike = new Intern { FirstName = "Mike", LastName = "Mike", Age = 21, HasExperience = false };
        var carl = new Intern { FirstName = "Carl", LastName = "Carl", Age = 40, HasExperience = true };
        var ben = new Intern { FirstName = "Ben", LastName = "Ben", Age = 32, HasExperience = false };

        descSortedList.Add(ben, 1);
        descSortedList.Add(john, 2);
        descSortedList.Add(mike, 3);
        descSortedList.Add(carl, 4);

        //the values at output should be in the following order : 4, 1, 3, 2
        for (int i = 0; i < descSortedList.Count; i++)
        {
            Console.WriteLine("Intern age: {0}, value: {1}", descSortedList.Keys[i].Age, descSortedList.Values[i]);
        }
    }
}