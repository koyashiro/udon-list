using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonDecimalListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<decimal>.New();
            list.Add(100m);
            list.Add(101m);
            list.Add(102m);
            Assert.Equal(100m, list.Get(0), this);
            Assert.Equal(101m, list.Get(1), this);
            Assert.Equal(102m, list.Get(2), this);
            Assert.Equal(new decimal[] { 100m, 101m, 102m }, list.ToArray(), this);
            Assert.True(list.Remove(101m), this);
            Assert.False(list.Remove(103m), this);
            Assert.Equal(100m, list.Get(0), this);
            Assert.Equal(102m, list.Get(1), this);
            Assert.Equal(new decimal[] { 100m, 102m }, list.ToArray(), this);
            list.Set(1, 101m);
            Assert.Equal(new decimal[] { 100m, 101m }, list.ToArray(), this);

            list = UdonList<decimal>.New(new decimal[] { 0m, 1m, 2m, 3m, 4m });
            list.Reverse();
            Assert.Equal(new decimal[] { 4m, 3m, 2m, 1m, 0m }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new decimal[] { 4m, 1m, 2m, 3m, 0m }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new decimal[] { 0m, 1m, 2m, 3m, 4m }, list.ToArray(), this);
        }
    }
}
