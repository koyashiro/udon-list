# UdonList

List implementation for UdonSharp.

## Example

```cs
using UdonSharp;
using UnityEngine;
using Koyashiro.UdonList;

public class UdonListExample : UdonSharpBehaviour
{
    public void Start()
    {
        // var list = new List<string>();
        var list = UdonList.New(); // []

        // list.Add("first");
        UdonList.Add(list, "first"); // ["first"];

        // list.Add("second");
        UdonList.Add(list, "second"); // ["first", "second"]

        // list.Add("third");
        UdonList.Add(list, "third"); // ["first", "second", "third"]

        // Debug.Log(list.Count);
        Debug.Log(UdonList.GetCount(list)); // 3

        // Debug.Log(list[0]);
        Debug.Log(UdonList.GetItem(list, 0)); // "first"

        // Debug.Log(list[1]);
        Debug.Log(UdonList.GetItem(list, 1)); // "second"

        // Debug.Log(list[2]);
        Debug.Log(UdonList.GetItem(list, 2)); // "third"

        // var array = list.ToArray();
        var array = UdonList.ToArray(list);
    }
}

```
