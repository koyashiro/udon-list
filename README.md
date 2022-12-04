# UdonList

List implementation for UdonSharp.

## Example

String list exmaple.  
You can also make UdonIntList, UdonFloatList, UdonBoolList, UdonObjectList and so on.

```cs
using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList;

public class UdonListSample : UdonSharpBehaviour
{
    public void Start()
    {
        var list = UdonStringList.New(); // Same as C# "new List<string>()";
        list.Add("first");    // ["first"]
        list.Add("second");   // ["first", "second"]
        list.Add("third");    // ["first", "second","third"]
        list.Remove("second");    // ["first", "third"]

        //List to array
        var convertedArray = list.ToArray();

        //Array to list
        var convertedList = UdonStringList.New(convertedArray);

        //Alternative foreach
        for (var i = 0; i < convertedList.Count(); i++)
        {
            Debug.Log(list.GetItem(i)); // "first", "third"
        }
    }
}
```
