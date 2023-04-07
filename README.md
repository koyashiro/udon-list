# UdonList

List implementation for UdonSharp.

## Installation

To use this package, you need to add [my package repository](https://github.com/koyashiro/vpm-repos).
Please read more details [here](https://github.com/koyashiro/vpm-repos#installation).

Please install this package with [Creator Companion](https://vcc.docs.vrchat.com/) or [VPM CLI](https://vcc.docs.vrchat.com/vpm/cli/).

### Creator Companion

1. Enable the `koyashiro` package repository.

   ![image](https://user-images.githubusercontent.com/6698252/230629434-048cde39-a0ec-4c53-bfe2-46bde2e6a57a.png)

2. Find `UdonList` from the list of packages and install any version you want.

### VPM CLI

1. Execute the following command to install the package.

   ```sh
   vpm add package net.koyashiro.udonlist
   ```

## Example

`UdonList` example for a `string`.

In addition, `UdonList<int>`, `UdonList<float>`, `UdonList<bool>`,
`UdonList<UdonSharpBehaviour>`, `UdonList<object>`, and so on can be used.

```cs
using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList;

public class UdonListSample : UdonSharpBehaviour
{
    private void Start()
    {
        var list = UdonList<string>.New(); // Same as C# `new List<string>();`
        list.Add("first");     // ["first"]
        list.Add("second");    // ["first", "second"]
        list.Add("third");     // ["first", "second", "third"]
        list.Remove("second"); // ["first", "third"]

        // List to array
        var convertedArray = list.ToArray();

        // Array to list
        var convertedList = UdonList<string>.New(convertedArray);

        // Alternative foreach
        for (var i = 0; i < convertedList.Count(); i++)
        {
            Debug.Log(list.GetValue(i)); // "first", "third"
        }
    }
}
```
