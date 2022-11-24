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
        list.Add("second");   // ["first","second"]
        list.Add("third");    // ["first","second","third"]
        list.RemoveAt(list.IndexOf("second"));    // ["first","third"]

        //List to array
        var arrayConv = list.ToArray();

        //Array to list
        var listConv = UdonStringList.New(arrayConv);

        //Alternative foreach
        for (int i = 0; i < listConv.Count(); i++)
        {
            Debug.Log(list.GetItem(i)); // "first","third"
        }
    }
}
```
