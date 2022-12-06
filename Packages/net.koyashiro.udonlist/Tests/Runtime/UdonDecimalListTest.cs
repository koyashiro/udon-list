using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonDecimalListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonDecimalList.New();
            list.Add(100m);
            list.Add(101m);
            list.Add(102m);
            Assert.Equal(100m, list.GetItem(0));
            Assert.Equal(101m, list.GetItem(1));
            Assert.Equal(102m, list.GetItem(2));
            Assert.Equal(new decimal[] { 100m, 101m, 102m }, list.ToArray());
            Assert.True(list.Remove(101m));
            Assert.False(list.Remove(103m));
            Assert.Equal(100m, list.GetItem(0));
            Assert.Equal(102m, list.GetItem(1));
            Assert.Equal(new decimal[] { 100m, 102m }, list.ToArray());
            list.SetItem(1, 101m);
            Assert.Equal(new decimal[] { 100m, 101m }, list.ToArray());

            list = UdonDecimalList.New(new decimal[] { 0m, 1m, 2m, 3m, 4m });
            list.Reverse();
            Assert.Equal(new decimal[] { 4m, 3m, 2m, 1m, 0m }, list.ToArray());
            list.Reverse(1, 3);
            Assert.Equal(new decimal[] { 4m, 1m, 2m, 3m, 0m }, list.ToArray());

            list.Sort();
            Assert.Equal(new decimal[] { 0m, 1m, 2m, 3m, 4m }, list.ToArray());
        }
    }
}
