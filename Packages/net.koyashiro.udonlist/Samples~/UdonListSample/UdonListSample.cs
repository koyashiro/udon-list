using UdonSharp;
using UnityEngine;
using Koyashiro.UdonList;

public class UdonListSample : UdonSharpBehaviour
{
    public void Start()
    {
        // var list = new List<string>();
        var list = UdonList.New(); // []

        list.Add("first"); // ["first"];
        list.Add("second"); // ["first", "second"]
        list.Add("third"); // ["first", "second", "third"]

        Debug.Log(list.GetCount()); // 3

        Debug.Log(list.GetItem(0)); // "first"
        Debug.Log(list.GetItem(1)); // "second"
        Debug.Log(list.GetItem(2)); // "third"

        var array = list.ToArray();
    }
}
