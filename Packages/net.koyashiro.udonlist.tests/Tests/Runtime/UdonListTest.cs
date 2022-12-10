using System;
using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class UdonListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            UdonList<decimal> list;

            list = UdonList<decimal>.New();
            Assert.Equal(0, list.Count(), this);
            list = UdonList<decimal>.New(5);
            Assert.Equal(0, list.Count(), this);
            list = UdonList<decimal>.New(new decimal[] { 1, 2, 3 });
            Assert.Equal(3, list.Count(), this);
            list.EnsureCapacity(10);
            Assert.Equal(10, ((Array)((object[])(object)list)[0]).Length, this);
            Assert.Equal(3, list.Count(), this);
            list.Add(0m);
            list.SetItem(3, 4m);
            Assert.Equal(4m, list.GetItem(3), this);
            list.Add(5m);
            list.AddRange(new decimal[] { 6, 7 });
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 6, 7 }, list.ToArray(), this);
            Assert.True(list.Contains(4m), this);
            var array = new decimal[list.Count()];
            list.CopyTo(array);
            Assert.Equal(list.ToArray(), array, this);
            list.Clear();
            Assert.Equal(0, list.Count(), this);
            list = UdonList<decimal>.New(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 });
            Assert.Equal(10, list.Count(), this);
            Assert.Equal(new decimal[] { 2, 3, 4 }, list.GetRange(1, 3).ToArray(), this);
            Assert.Equal(2, list.IndexOf(3m), this);
            Assert.Equal(7, list.IndexOf(3m, 4), this);
            Assert.Equal(7, list.LastIndexOf(3m), this);
            list.Insert(5, 0m);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 0, 1, 2, 3, 4, 5 }, list.ToArray(), this);
            list.InsertRange(5, new decimal[] { 0, 1, 2 });
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 0, 1, 2, 0, 1, 2, 3, 4, 5 }, list.ToArray(), this);
            list.Remove(0m);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 0, 1, 2, 3, 4, 5 }, list.ToArray(), this);
            list.RemoveAt(7);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 1, 2, 3, 4, 5 }, list.ToArray(), this);
            list.RemoveRange(5, 2);
            Assert.Equal(new decimal[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 }, list.ToArray(), this);
            list.Reverse();
            Assert.Equal(new decimal[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 1 }, list.ToArray(), this);
            list.Reverse(2, 3);
            Assert.Equal(new decimal[] { 5, 4, 1, 2, 3, 5, 4, 3, 2, 1 }, list.ToArray(), this);
            list.Sort(2, 5);
            Assert.Equal(new decimal[] { 5, 4, 1, 2, 3, 4, 5, 3, 2, 1 }, list.ToArray(), this);
            list.Sort();
            Assert.Equal(new decimal[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 }, list.ToArray(), this);
        }
    }
}
