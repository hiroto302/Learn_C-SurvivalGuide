using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqExample : MonoBehaviour
{
    string[] names = {"abc", "a", "b", "c", "d", "e", "efgh"};
    int [] quizGrades = {1, 3, 5, 2, 10, 123};

    void Start()
    {
        // Any
        var nameFound = names.Any(name => name == "c");
        // Debug.Log("nameFound : " + nameFound);

        // Contains
        var nameContain = name.Contains("d");
        // Debug.Log("nameContains : " + nameContain);

        // Distinct
        var uniqueNames = names.Distinct();
        foreach(var name in uniqueNames)
        {
            // Debug.Log(name);
        }

        // Where
        var result = names.Where(n => n.Length > 2);
        foreach(var name in result)
        {
            // Debug.Log(name);
        }

        // Where, OrderByDescending, Reverse
        var passingGrades = quizGrades.Where(qg => qg > 4).OrderByDescending(q => q).Reverse();
        foreach (var grade in passingGrades)
        {
            Debug.Log(grade);
        }



        // foreach (var name in names)
        // {
        //     if(name == "c")
        //     {
        //         Debug.Log("match !! : " + name);
        //     }
        // }
    }
}
