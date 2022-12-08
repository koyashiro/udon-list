using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class UdonListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            Debug.Log("UdonListTest");

            UdonDecimalList list;

            list = UdonDecimalList.New();
            Assert.Equal(0, list.Count());
            list = UdonDecimalList.New(5);
            Assert.Equal(0, list.Count());
            list = UdonDecimalList.New(new decimal[] { 1, 2, 3 });
            Assert.Equal(3, list.Count());
            list.Add(0);
            list.SetItem(3, 4);
            Assert.Equal(4m, list.GetItem(3));
            list.Add(5);
            list.AddRange(new decimal[] { 6, 7 });
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 6, 7 }, list.ToArray());
            Assert.True(list.Contains(4));
            var array = new decimal[list.Count()];
            list.CopyTo(array);
            Assert.Equal(list.ToArray(), array);
            list.Clear();
            Assert.Equal(0, list.Count());
            list = UdonDecimalList.New(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 });
            Assert.Equal(10, list.Count());
            Assert.Equal(new decimal[] { 2, 3, 4 }, list.GetRange(1, 3).ToArray());
            Assert.Equal(2, list.IndexOf(3));
            Assert.Equal(7, list.IndexOf(3, 4));
            Assert.Equal(7, list.LastIndexOf(3));
            list.Insert(5, 0);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 0, 1, 2, 3, 4, 5 }, list.ToArray());
            list.InsertRange(5, new decimal[] { 0, 1, 2 });
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 0, 1, 2, 0, 1, 2, 3, 4, 5 }, list.ToArray());
            list.Remove(0);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 0, 1, 2, 3, 4, 5 }, list.ToArray());
            list.RemoveAt(7);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 1, 2, 3, 4, 5 }, list.ToArray());
            list.RemoveRange(5, 2);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 }, list.ToArray());
            list.Reverse();
            Assert.Equal(new decimal[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 1 }, list.ToArray());
            list.Reverse(2, 3);
            Assert.Equal(new decimal[] { 5, 4, 1, 2, 3, 5, 4, 3, 2, 1 }, list.ToArray());
            list.Sort(2, 5);
            Assert.Equal(new decimal[] { 5, 4, 1, 2, 3, 4, 5, 3, 2, 1 }, list.ToArray());
            list.Sort();
            Assert.Equal(new decimal[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, list.ToArray());
        }
    }
}
